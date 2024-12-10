using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.IO;
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
        /// Сериализация данных
        /// </summary>
        /// <param name="data">Список данных</param>
        public static void SaveEntries(string path, List<PasswordEntry> data)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
                serializer.Serialize(writer, data);
        }

        /// <summary>
        /// Десериализация данных
        /// </summary>
        /// <returns>Список данных</returns>
        public static List<PasswordEntry> LoadEntries(string path)
        {
            List<PasswordEntry> PasswordList;

            JsonSerializer serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader(path))
            using (JsonReader reader = new JsonTextReader(sr))
                PasswordList = serializer.Deserialize<List<PasswordEntry>>(reader);


           return PasswordList;
        }

        private static string _filePath;
    }
}