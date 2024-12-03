using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
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
        /// Инициализация класса для работы с файлом
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        public EntriesWorker(string path) 
        {
            _filePath = path;
        }
        
        /// <summary>
        /// Сериализация данных
        /// </summary>
        /// <param name="data">Список данных</param>
        public void SaveEntries(List<PasswordEntry> data)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(_filePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
                serializer.Serialize(writer, data);
        }

        /// <summary>
        /// Десериализация данных
        /// </summary>
        /// <returns>Список данных</returns>
        public List<PasswordEntry> LoadEntries()
        {
            List<PasswordEntry> PasswordList;

            JsonSerializer serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader(_filePath))
            using (JsonReader reader = new JsonTextReader(sr))
                PasswordList = serializer.Deserialize<List<PasswordEntry>>(reader);

            return PasswordList;
        }

        private static string _filePath;
    }
}