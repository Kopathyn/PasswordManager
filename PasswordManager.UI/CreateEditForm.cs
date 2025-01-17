using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManager;

namespace PasswordManager.UI
{
    public partial class CreateEditForm : Form
    {
        public CreateEditForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!CheckErrors())
            {
                MessageBox.Show("В данном окне есть ошибки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PasswordNameError.Clear();
                try
                {
                    passwordEntry.PasswordName = PasswordNameBox.Text;
                    passwordEntry.Login = LoginTextBox.Text;
                    passwordEntry.Password = PasswordTextBox.Text;

                    if (LinkTextBox.Text != null)
                        passwordEntry.ServiceLink = LinkTextBox.Text;
                    else
                        passwordEntry.ServiceLink = null;

                    passwordEntry.Notes = NotesTextBox.Text;

                    DialogResult = DialogResult.OK;

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка ввода!\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CheckErrors()
        {
            if (PasswordNameBox.Text == null || PasswordNameError.HasErrors)
            {
                PasswordNameError.SetError(PasswordNameBox, "Это поле не может быть пустым!");
                return false;
            }
            return true;
        }

        public PasswordEntry passwordEntry = new();

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Text = PasswordGenerator.GeneratePassword();
        }

        private void CreateEditForm_Load(object sender, EventArgs e)
        {
            if (passwordEntry != null)
            {
                PasswordNameBox.Text = passwordEntry.PasswordName;
                LoginTextBox.Text = passwordEntry.Login;
                PasswordTextBox.Text = passwordEntry.Password;

                if (passwordEntry.ServiceLink != null)
                    LinkTextBox.Text = passwordEntry.ServiceLink;

                if (passwordEntry.Notes != null)
                    NotesTextBox.Text = passwordEntry.Notes;
            }
        }
    }
}