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

        private void PasswordNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            PasswordEntry.PasswordName = PasswordNameBox.Text;
            PasswordEntry.Login = LoginTextBox.Text;
            PasswordEntry.Password = PasswordTextBox.Text;

            if (LinkTextBox.Text != null)
                PasswordEntry.ServiceLink = LinkTextBox.Text;
            else
                PasswordEntry.ServiceLink = null;

            PasswordEntry.Notes = NotesTextBox.Text;

            DialogResult = DialogResult.OK;

            this.Close();
        }

        public PasswordEntry PasswordEntry = new();
    }
}