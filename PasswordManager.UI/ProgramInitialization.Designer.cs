namespace PasswordManager.UI
{
    partial class ProgramInitialization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramInitialization));
            FilePathLabel = new Label();
            FilePathBox = new TextBox();
            SearchPathButton = new Button();
            SearchFileDialog = new OpenFileDialog();
            SelectButton = new Button();
            CreateButton = new Button();
            FolderForNewFileDialog = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // FilePathLabel
            // 
            FilePathLabel.AutoSize = true;
            FilePathLabel.Location = new Point(12, 34);
            FilePathLabel.Name = "FilePathLabel";
            FilePathLabel.Size = new Size(198, 15);
            FilePathLabel.TabIndex = 0;
            FilePathLabel.Text = "Укажите путь к файлу с паролями:";
            // 
            // FilePathBox
            // 
            FilePathBox.Location = new Point(12, 61);
            FilePathBox.Name = "FilePathBox";
            FilePathBox.Size = new Size(473, 23);
            FilePathBox.TabIndex = 2;
            // 
            // SearchPathButton
            // 
            SearchPathButton.Location = new Point(491, 61);
            SearchPathButton.Name = "SearchPathButton";
            SearchPathButton.Size = new Size(75, 23);
            SearchPathButton.TabIndex = 3;
            SearchPathButton.Text = "Обзор";
            SearchPathButton.UseVisualStyleBackColor = true;
            SearchPathButton.Click += SearchPathButton_Click;
            // 
            // SearchFileDialog
            // 
            SearchFileDialog.InitialDirectory = "Documents";
            SearchFileDialog.Title = "Выберите файл";
            // 
            // SelectButton
            // 
            SelectButton.Location = new Point(410, 117);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(75, 23);
            SelectButton.TabIndex = 4;
            SelectButton.Text = "Выбрать";
            SelectButton.UseVisualStyleBackColor = true;
            SelectButton.Click += SelectButton_Click;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(491, 117);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(75, 23);
            CreateButton.TabIndex = 5;
            CreateButton.Text = "Создать";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // FolderForNewFileDialog
            // 
            FolderForNewFileDialog.Description = "Выберите место для файла";
            // 
            // ProgramInitialization
            // 
            AcceptButton = SelectButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 165);
            Controls.Add(CreateButton);
            Controls.Add(SelectButton);
            Controls.Add(SearchPathButton);
            Controls.Add(FilePathBox);
            Controls.Add(FilePathLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ProgramInitialization";
            Text = "Менеджер паролей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FilePathLabel;
        private TextBox FilePathBox;
        private Button SearchPathButton;
        private OpenFileDialog SearchFileDialog;
        private Button SelectButton;
        private Button CreateButton;
        private FolderBrowserDialog FolderForNewFileDialog;
    }
}