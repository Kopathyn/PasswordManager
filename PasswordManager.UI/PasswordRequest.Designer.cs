namespace PasswordManager.UI
{
    partial class PasswordRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordRequest));
            RequestLabel = new Label();
            PasswordTextBox = new TextBox();
            OKButton = new Button();
            CancelButton = new Button();
            ShowPassword = new CheckBox();
            CheckBoxTip = new ToolTip(components);
            SuspendLayout();
            // 
            // RequestLabel
            // 
            RequestLabel.AutoSize = true;
            RequestLabel.Location = new Point(12, 43);
            RequestLabel.Name = "RequestLabel";
            RequestLabel.Size = new Size(149, 15);
            RequestLabel.TabIndex = 0;
            RequestLabel.Text = "Введите пароль от файла:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(167, 40);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(321, 23);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // OKButton
            // 
            OKButton.Location = new Point(332, 92);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 23);
            OKButton.TabIndex = 2;
            OKButton.Text = "ОК";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(413, 92);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ShowPassword
            // 
            ShowPassword.AutoSize = true;
            ShowPassword.Location = new Point(494, 44);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new Size(15, 14);
            ShowPassword.TabIndex = 4;
            CheckBoxTip.SetToolTip(ShowPassword, "Нажмите, чтобы увидеть/скрыть пароль\r\n");
            ShowPassword.UseVisualStyleBackColor = true;
            ShowPassword.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // PasswordRequest
            // 
            AcceptButton = OKButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 127);
            Controls.Add(ShowPassword);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(RequestLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PasswordRequest";
            Text = "Менеджер паролей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RequestLabel;
        private TextBox PasswordTextBox;
        private Button OKButton;
        private Button CancelButton;
        private CheckBox ShowPassword;
        private ToolTip CheckBoxTip;
    }
}