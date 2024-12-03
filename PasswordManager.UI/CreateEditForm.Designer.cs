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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEditForm));
            LoginLabel = new Label();
            PasswordLabel = new Label();
            LinkLabel = new Label();
            NotesLabel = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LinkTextBox = new TextBox();
            NotesTextBox = new TextBox();
            PasswordNameBox = new TextBox();
            Name = new Label();
            GenerateButton = new Button();
            PasswordStrength = new ProgressBar();
            SaveButton = new Button();
            PasswordStrenghtDesc = new Label();
            PasswordNameErr = new ErrorProvider(components);
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)PasswordNameErr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
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
            LinkLabel.Location = new Point(31, 199);
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
            LinkTextBox.Location = new Point(125, 191);
            LinkTextBox.Name = "LinkTextBox";
            LinkTextBox.PlaceholderText = "Ссылка на ресурс";
            LinkTextBox.Size = new Size(246, 23);
            LinkTextBox.TabIndex = 6;
            // 
            // NotesTextBox
            // 
            NotesTextBox.Location = new Point(125, 243);
            NotesTextBox.Multiline = true;
            NotesTextBox.Name = "NotesTextBox";
            NotesTextBox.PlaceholderText = "Заметки";
            NotesTextBox.Size = new Size(246, 184);
            NotesTextBox.TabIndex = 7;
            // 
            // PasswordNameBox
            // 
            PasswordNameBox.Location = new Point(125, 27);
            PasswordNameBox.Name = "PasswordNameBox";
            PasswordNameBox.PlaceholderText = "Название";
            PasswordNameBox.Size = new Size(246, 23);
            PasswordNameBox.TabIndex = 9;
            PasswordNameBox.TextChanged += PasswordNameBox_TextChanged;
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
            PasswordStrength.Location = new Point(125, 141);
            PasswordStrength.Name = "PasswordStrength";
            PasswordStrength.Size = new Size(246, 10);
            PasswordStrength.TabIndex = 11;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(475, 414);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 13;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // PasswordStrenghtDesc
            // 
            PasswordStrenghtDesc.AutoSize = true;
            PasswordStrenghtDesc.Location = new Point(125, 154);
            PasswordStrenghtDesc.Name = "PasswordStrenghtDesc";
            PasswordStrenghtDesc.Size = new Size(78, 15);
            PasswordStrenghtDesc.TabIndex = 14;
            PasswordStrenghtDesc.Text = "Сила пароля";
            PasswordStrenghtDesc.Visible = false;
            // 
            // PasswordNameErr
            // 
            PasswordNameErr.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            PasswordNameErr.ContainerControl = this;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider2.ContainerControl = this;
            // 
            // CreateEditForm
            // 
            AcceptButton = SaveButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 469);
            Controls.Add(PasswordStrenghtDesc);
            Controls.Add(SaveButton);
            Controls.Add(PasswordStrength);
            Controls.Add(GenerateButton);
            Controls.Add(PasswordNameBox);
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
            //Name = "CreateEditForm";
            Text = "Создание/Изменение пароля";
            ((System.ComponentModel.ISupportInitialize)PasswordNameErr).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
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
        private TextBox PasswordNameBox;
        private Label Name;
        private Button GenerateButton;
        private ProgressBar PasswordStrength;
        private Button SaveButton;
        private Label PasswordStrenghtDesc;
        private ErrorProvider PasswordNameErr;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}