using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PasswordManager
{
    /// <summary>
    /// Класс, сериализации данных из файла
    /// </summary>
    public class EntriesWorker
    {        
        /// <summary>
        /// Сериализация данных
        /// </summary>
        /// <param name="data">Список данных</param>
        public static void SaveEntries(string path, string key, List<PasswordEntry> data)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
                serializer.Serialize(writer, data);

            EncryptFile(path, key);
        }

        /// <summary>
        /// Десериализация данных
        /// </summary>
        /// <returns>Список данных</returns>
        public static List<PasswordEntry> LoadEntries(string path, string key)
        {
            List<PasswordEntry> PasswordList;

            JsonSerializer serializer = new JsonSerializer();

            DecryptFile(path, key);

            using (StreamReader sr = new StreamReader(path))
            using (JsonReader reader = new JsonTextReader(sr))
                try
                {
                    PasswordList = serializer.Deserialize<List<PasswordEntry>>(reader);

                    return PasswordList;
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка десериализации!");
                }
        }

        /// <summary>
        /// Функция генерации ключа для AES
        /// </summary>
        /// <param name="key">Базовый ключ</param>
        /// <returns>Преобразованный ключ</returns>
        private static byte[] GenerateKey(string key)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(key));
            }
        }

        /// <summary>
        /// Шифрование содержимого файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="key">Ключ</param>
        private static void EncryptFile(string path, string key)
        {
            byte[] encryptionKey = GenerateKey(key);

            string tmpPath = Path.GetTempFileName();
            using (FileStream fsSrc = File.OpenRead(path))
            using (Aes aes = Aes.Create())
            using (FileStream fsDst = File.Create(tmpPath))
            {
                aes.Key = encryptionKey;
                fsDst.Write(aes.IV);
                using (CryptoStream cs = new CryptoStream(fsDst, aes.CreateEncryptor(), CryptoStreamMode.Write, true))
                {
                    fsSrc.CopyTo(cs);
                }
            }
            File.Delete(path);
            File.Move(tmpPath, path);
        }

        /// <summary>
        /// Дешифрование файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="key">Ключ</param>
        private static void DecryptFile(string path, string key)
        {
            byte[] encryptionKey = GenerateKey(key);

            string tmpPath = Path.GetTempFileName();
            using (FileStream fsSrc = File.OpenRead(path))
            {
                byte[] iv = new byte[16];
                fsSrc.Read(iv);
                using (Aes aes = Aes.Create())
                {
                    aes.Key = encryptionKey;
                    aes.IV = iv;
                    using (CryptoStream cs = new CryptoStream(fsSrc, aes.CreateDecryptor(), CryptoStreamMode.Read, true))
                    using (FileStream fsDst = File.Create(tmpPath))
                    {
                        cs.CopyTo(fsDst);
                    }
                }
            }
            File.Delete(path);
            File.Move(tmpPath, path);
        }
    }
}