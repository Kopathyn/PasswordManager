using System.Text.RegularExpressions;

namespace PasswordManager
{
    /// <summary>
    /// Класс, описывающий запись о пароле
    /// </summary>
    public class PasswordEntry
    {
        /// <summary>
        /// Базовый конструктор класса
        /// </summary>
        public PasswordEntry()
        {
            _login = null;
            _password = null; 
            _passwordName = null;
            _serviceLink = null;
            _notes = null; 
        }

        /// <summary>
        /// Функция генерации пароля
        /// </summary>
        public string GeneratePassword()
        {
            Random random = new Random();

            string AvalibleChars = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            const int PasswordLength = 12;

            string GeneratedPassword = "";
            for (int i = 0; i < PasswordLength; i++)
                GeneratedPassword += AvalibleChars[random.Next(AvalibleChars.Length)];

            return GeneratedPassword;
        }

        #region PublicFields

        public string PasswordName
        {
            get { return _passwordName; }

            set
            {
                if (value != null && value.Length <= 50)
                    _passwordName = value;
                else
                    throw new ArgumentException("Имя не должно быть больше 50 символов!");
            }
        }

        public string Login
        {
            get { return _login; }

            set
            {
                if (value != null && value.Length <= 50 && Regex.IsMatch(value, @"^[a-zA-Z0-9\p{L}.,!?]+$"))
                    _login = value;
                else
                    throw new ArgumentException("Логин не должен быть больше 50 символов, состоять из кириллицы!");
            }
        }

        public string Password
        {
            get { return _password; }

            set
            {
                if (value != null && value.Length <= 50 && Regex.IsMatch(value, @"^[a-zA-Z0-9\p{L}.,!?]+$"))
                    _password = value;
                else
                    throw new ArgumentException("Пароль не должен быть больше 50 символов и состоять из кириллицы!");
            }
        }

        public string ServiceLink
        {
            get { return _serviceLink; }

            set
            {
                if (value != null && value.Length <= 100 && Regex.IsMatch(value, @"^[a-zA-Z0-9\p{L}.,!?]+$"))
                    _serviceLink = value;
                else
                    throw new ArgumentException("Ссылка не должна быть больше 100 символов и состоять из кириллицы!");
            }
        }

        public string Notes
        {
            get { return _notes; }

            set
            {
                if (value != null && value.Length <= 100)
                    _notes = value;
                else
                    throw new ArgumentException("Заметка не должна быть больше 100");
            }
        }

        #endregion

        #region PrivateFields

        private string? _login;
        private string? _password;
        private string? _passwordName;
        private string? _serviceLink;
        private string? _notes;

        #endregion

    }
}