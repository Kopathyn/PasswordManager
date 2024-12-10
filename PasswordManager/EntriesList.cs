using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    public class EntriesList
    {
        /// <summary>
        /// Инициализация пустого списка
        /// </summary>
        public EntriesList() 
        {
            entries = new List<PasswordEntry> ();
        }

        /// <summary>
        /// Инициализация списка из json файла
        /// </summary>
        /// <param name="path">Путь к json</param>
        public EntriesList(string path)
        {
            entries = EntriesWorker.LoadEntries(path);
        }

        /// <summary>
        /// Поиск записи по имени сервиса
        /// </summary>
        /// <param name="name">Имя сервиса</param>
        /// <returns>Запись о пароле</returns>
        public PasswordEntry FindEntryByName(string name)
        {
            foreach (var entry in entries) 
                if (entry.PasswordName == name)
                    return entry;

            return null;
        }

        /// <summary>
        /// Добавление записи в список
        /// </summary>
        /// <param name="entry">Запись</param>
        public void Add(PasswordEntry entry)
        {
            entries.Add(entry);
        }

        /// <summary>
        /// Поиск номера записи в списке по названию
        /// </summary>
        /// <param name="name">Название записи о пароле</param>
        /// <returns>Порядковый номер записи в списке</returns>
        public int FindEntryNum(string name)
        {
            for (int i = 0; i < entries.Count; i++)
            {
                if (entries[i].PasswordName == name)
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Удаление записи по индексу
        /// </summary>
        /// <param name="num">Номер записи в списке</param>
        public void RemoveEntry(int num)
        {
            entries.RemoveAt(num);
        }

        public List<PasswordEntry> entries;
    }
}
