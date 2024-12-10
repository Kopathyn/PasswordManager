using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    public class PasswordGenerator
    {
        /// <summary>
        /// Функция генерации пароля
        /// </summary>
        public static string GeneratePassword()
        {
            Random random = new Random();

            string AvalibleChars = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            const int PasswordLength = 12;

            string GeneratedPassword = "";
            for (int i = 0; i < PasswordLength; i++)
                GeneratedPassword += AvalibleChars[random.Next(AvalibleChars.Length)];

            return GeneratedPassword;
        }
    }
}
