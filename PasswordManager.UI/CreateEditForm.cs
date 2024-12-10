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

        public CreateEditForm(PasswordEntry EntryToEdit)
        {
            passwordEntry = EntryToEdit;
            InitializeComponent();

            PasswordNameBox.Text = passwordEntry.PasswordName;
            LoginTextBox.Text = passwordEntry.Login;
            PasswordNameBox.Text = passwordEntry.Password;

            if (passwordEntry.ServiceLink != null)
                LinkTextBox.Text = passwordEntry.ServiceLink;

            if (passwordEntry.Notes != null)
                NotesTextBox.Text = passwordEntry.Notes;
        }

        private void SaveButton_Click(object sender, EventArgs e)
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

        public PasswordEntry passwordEntry = new();

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Text = PasswordGenerator.GeneratePassword();
        }
    }
}