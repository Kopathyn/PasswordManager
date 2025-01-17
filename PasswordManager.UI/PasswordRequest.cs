using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.UI
{
    public partial class PasswordRequest : Form
    {
        public PasswordRequest()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            PasswordKey = PasswordTextBox.Text;

            if (PasswordKey != null && Regex.IsMatch(PasswordKey, @"^[a-zA-Z0-9\p{L}.,!?]+$"))
                this.Close();
            else
                MessageBox.Show("Пароль не может быть пустой строкой и состоять из кириллиицы!", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            RequestResult = DialogResult.Cancel;
            this.Close();
        }

        public string PasswordKey;
        public DialogResult RequestResult;
    }
}
