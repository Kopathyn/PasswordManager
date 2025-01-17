using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.UI
{
    public partial class ProgramInitialization : Form
    {
        public ProgramInitialization()
        {
            InitializeComponent();
        }

        private void SearchPathButton_Click(object sender, EventArgs e)
        {
            DialogResult SearchResult = SearchFileDialog.ShowDialog(this);

            if (SearchResult == DialogResult.OK)
                FilePathBox.Text = SearchFileDialog.FileName;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            string FilePath = FilePathBox.Text;

            if (FilePathBox.Text == null || FilePath == "" || FilePath == " ")
                MessageBox.Show("Не указан путь к файлу!", "Путь к файлу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!FilePath.Contains(".json"))
                MessageBox.Show("Файл должен быть формата .json", "Неверно выбран формат файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                PasswordRequest passwordRequest = new PasswordRequest();
                passwordRequest.ShowDialog();

                _passwordKey = passwordRequest.PasswordKey;
                _trueFilePath = FilePath;

                try
                {
                    EntriesList newEntriesList = new EntriesList();

                    newEntriesList.Entries = EntriesWorker.LoadEntries(FilePath, _passwordKey);

                    MainForm mainForm = new MainForm(newEntriesList);
                    this.Hide();
                    mainForm.ShowDialog();

                    this.Show();

                    EntriesWorker.SaveEntries(_trueFilePath, _passwordKey, mainForm.AllEntries.Entries);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка чтения файла!");
                }
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            DialogResult selectFolder = FolderForNewFileDialog.ShowDialog(this);

            if (selectFolder == DialogResult.OK)
            {
                PasswordRequest passwordRequest = new PasswordRequest();
                passwordRequest.ShowDialog();

                if (passwordRequest.RequestResult != DialogResult.Cancel)
                {
                    _passwordKey = passwordRequest.PasswordKey;

                    _trueFilePath = FolderForNewFileDialog.SelectedPath + "\\Passwords.json";
                    File.Create(_trueFilePath).Close();
                    MessageBox.Show($"Файл успешно создан!", "Новый файл", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    EntriesList entries = new EntriesList();
                    MainForm mainForm = new MainForm(entries);
                    mainForm.ShowDialog();

                    this.Show();
                    EntriesWorker.SaveEntries(_trueFilePath, _passwordKey, mainForm.AllEntries.Entries);
                }
            }
        }

        private string _trueFilePath;
        private string _passwordKey;
    }
}