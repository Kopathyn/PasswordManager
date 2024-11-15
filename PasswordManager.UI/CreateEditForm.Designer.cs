namespace PasswordManager.UI
{
    partial class CreateEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEditForm));
            LoginLabel = new Label();
            PasswordLabel = new Label();
            LinkLabel = new Label();
            NotesLabel = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LinkTextBox = new TextBox();
            NotesTextBox = new TextBox();
            textBox1 = new TextBox();
            Name = new Label();
            GenerateButton = new Button();
            PasswordStrength = new ProgressBar();
            PasswordStrengthLabel = new Label();
            SaveButton = new Button();
            PasswordStrenghtDesc = new Label();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(27, 70);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(44, 15);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Логин:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(27, 115);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(52, 15);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Пароль:";
            // 
            // LinkLabel
            // 
            LinkLabel.AutoSize = true;
            LinkLabel.Location = new Point(27, 224);
            LinkLabel.Name = "LinkLabel";
            LinkLabel.Size = new Size(52, 15);
            LinkLabel.TabIndex = 2;
            LinkLabel.Text = "Ссылка:";
            // 
            // NotesLabel
            // 
            NotesLabel.AutoSize = true;
            NotesLabel.Location = new Point(27, 273);
            NotesLabel.Name = "NotesLabel";
            NotesLabel.Size = new Size(56, 15);
            NotesLabel.TabIndex = 3;
            NotesLabel.Text = "Заметки:";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(125, 67);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.PlaceholderText = "Ваш логин";
            LoginTextBox.Size = new Size(246, 23);
            LoginTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(125, 112);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PlaceholderText = "Ваш пароль";
            PasswordTextBox.Size = new Size(246, 23);
            PasswordTextBox.TabIndex = 5;
            // 
            // LinkTextBox
            // 
            LinkTextBox.Location = new Point(125, 224);
            LinkTextBox.Name = "LinkTextBox";
            LinkTextBox.PlaceholderText = "Ссылка на ресурс";
            LinkTextBox.Size = new Size(246, 23);
            LinkTextBox.TabIndex = 6;
            // 
            // NotesTextBox
            // 
            NotesTextBox.Location = new Point(125, 273);
            NotesTextBox.Multiline = true;
            NotesTextBox.Name = "NotesTextBox";
            NotesTextBox.PlaceholderText = "Заметки";
            NotesTextBox.Size = new Size(246, 184);
            NotesTextBox.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 27);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Название";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 9;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(27, 30);
            Name.Name = "Name";
            Name.Size = new Size(62, 15);
            Name.TabIndex = 8;
            Name.Text = "Название:";
            // 
            // GenerateButton
            // 
            GenerateButton.Location = new Point(399, 112);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(100, 23);
            GenerateButton.TabIndex = 10;
            GenerateButton.Text = "Сгенерировать";
            GenerateButton.UseVisualStyleBackColor = true;
            // 
            // PasswordStrength
            // 
            PasswordStrength.Location = new Point(125, 151);
            PasswordStrength.Name = "PasswordStrength";
            PasswordStrength.Size = new Size(246, 23);
            PasswordStrength.TabIndex = 11;
            // 
            // PasswordStrengthLabel
            // 
            PasswordStrengthLabel.AutoSize = true;
            PasswordStrengthLabel.Location = new Point(27, 155);
            PasswordStrengthLabel.Name = "PasswordStrengthLabel";
            PasswordStrengthLabel.Size = new Size(81, 15);
            PasswordStrengthLabel.TabIndex = 12;
            PasswordStrengthLabel.Text = "Сила пароля:";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(475, 414);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 13;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // PasswordStrenghtDesc
            // 
            PasswordStrenghtDesc.AutoSize = true;
            PasswordStrenghtDesc.Location = new Point(211, 186);
            PasswordStrenghtDesc.Name = "PasswordStrenghtDesc";
            PasswordStrenghtDesc.Size = new Size(78, 15);
            PasswordStrenghtDesc.TabIndex = 14;
            PasswordStrenghtDesc.Text = "Сила пароля";
            PasswordStrenghtDesc.Visible = false;
            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 469);
            Controls.Add(PasswordStrenghtDesc);
            Controls.Add(SaveButton);
            Controls.Add(PasswordStrengthLabel);
            Controls.Add(PasswordStrength);
            Controls.Add(GenerateButton);
            Controls.Add(textBox1);
            Controls.Add(Name);
            Controls.Add(NotesTextBox);
            Controls.Add(LinkTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(NotesLabel);
            Controls.Add(LinkLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CreateEditForm";
            Text = "Создание/Изменение пароля";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLabel;
        private Label PasswordLabel;
        private Label LinkLabel;
        private Label NotesLabel;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private TextBox LinkTextBox;
        private TextBox NotesTextBox;
        private TextBox textBox1;
        private Label Name;
        private Button GenerateButton;
        private ProgressBar PasswordStrength;
        private Label PasswordStrengthLabel;
        private Button SaveButton;
        private Label PasswordStrenghtDesc;
    }
}