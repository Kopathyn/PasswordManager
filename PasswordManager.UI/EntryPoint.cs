using Microsoft.VisualBasic.ApplicationServices;
using System.IO;

namespace PasswordManager.UI
{
    internal static class EntryPoint
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.Run(new ProgramInitialization());
            Application.Run(new MainForm($"C:\\Users\\chemo\\Desktop\\Passwords.json"));
        }
    }
}