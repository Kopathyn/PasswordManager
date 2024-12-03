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
                TrueFilePath = FilePath;
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            DialogResult SelectFolder = FolderForNewFileDialog.ShowDialog(this);

            if (SelectFolder == DialogResult.OK)
            {
                TrueFilePath = FolderForNewFileDialog.SelectedPath + "\\Passwords.json";
                File.Create(TrueFilePath).Close();
                MessageBox.Show($"Файл успешно создан!", "Новый файл", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                MainForm mainForm = new MainForm(TrueFilePath);
                mainForm.ShowDialog();
            }
        }

        private string TrueFilePath;
    }
}