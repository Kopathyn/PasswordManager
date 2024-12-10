namespace PasswordManager.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            EntriesListBox = new ListBox();
            MenuStrip = new MenuStrip();
            FileMenuStrip = new ToolStripMenuItem();
            AddMenuStrip = new ToolStripMenuItem();
            EditMenuStrip = new ToolStripMenuItem();
            ServiceNameLabel = new Label();
            LoginTextBox = new TextBox();
            PassWordTextBox = new TextBox();
            NotesTextBox = new TextBox();
            LinkLabel = new LinkLabel();
            NotesLabel = new Label();
            DelButton = new Button();
            GeneratePassButton = new Button();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            LogPassPanel = new Panel();
            MenuStrip.SuspendLayout();
            LogPassPanel.SuspendLayout();
            SuspendLayout();
            // 
            // EntriesListBox
            // 
            EntriesListBox.FormattingEnabled = true;
            EntriesListBox.ItemHeight = 15;
            EntriesListBox.Location = new Point(12, 24);
            EntriesListBox.Name = "EntriesListBox";
            EntriesListBox.Size = new Size(259, 409);
            EntriesListBox.TabIndex = 0;
            EntriesListBox.SelectedIndexChanged += PasswordsList_SelectedIndexChanged;
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileMenuStrip });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(701, 24);
            MenuStrip.TabIndex = 1;
            // 
            // FileMenuStrip
            // 
            FileMenuStrip.DropDownItems.AddRange(new ToolStripItem[] { AddMenuStrip, EditMenuStrip });
            FileMenuStrip.Name = "FileMenuStrip";
            FileMenuStrip.Size = new Size(48, 20);
            FileMenuStrip.Text = "Файл";
            // 
            // AddMenuStrip
            // 
            AddMenuStrip.Name = "AddMenuStrip";
            AddMenuStrip.Size = new Size(180, 22);
            AddMenuStrip.Text = "Создать";
            AddMenuStrip.Click += AddMenuStrip_Click;
            // 
            // EditMenuStrip
            // 
            EditMenuStrip.Name = "EditMenuStrip";
            EditMenuStrip.Size = new Size(180, 22);
            EditMenuStrip.Text = "Редактировать";
            EditMenuStrip.Click += EditMenuStrip_Click;
            // 
            // ServiceNameLabel
            // 
            ServiceNameLabel.AutoSize = true;
            ServiceNameLabel.Location = new Point(131, 9);
            ServiceNameLabel.Name = "ServiceNameLabel";
            ServiceNameLabel.Size = new Size(104, 15);
            ServiceNameLabel.TabIndex = 2;
            ServiceNameLabel.Text = "ServiceNameLabel";
            ServiceNameLabel.Visible = false;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Enabled = false;
            LoginTextBox.Location = new Point(427, 68);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.ReadOnly = true;
            LoginTextBox.Size = new Size(225, 23);
            LoginTextBox.TabIndex = 3;
            // 
            // PassWordTextBox
            // 
            PassWordTextBox.Enabled = false;
            PassWordTextBox.Location = new Point(427, 129);
            PassWordTextBox.Name = "PassWordTextBox";
            PassWordTextBox.ReadOnly = true;
            PassWordTextBox.Size = new Size(225, 23);
            PassWordTextBox.TabIndex = 4;
            // 
            // NotesTextBox
            // 
            NotesTextBox.Location = new Point(427, 192);
            NotesTextBox.Multiline = true;
            NotesTextBox.Name = "NotesTextBox";
            NotesTextBox.Size = new Size(225, 82);
            NotesTextBox.TabIndex = 6;
            // 
            // LinkLabel
            // 
            LinkLabel.AutoSize = true;
            LinkLabel.Location = new Point(198, 307);
            LinkLabel.Name = "LinkLabel";
            LinkLabel.Size = new Size(60, 15);
            LinkLabel.TabIndex = 7;
            LinkLabel.TabStop = true;
            LinkLabel.Text = "linkLabel1";
            LinkLabel.Visible = false;
            // 
            // NotesLabel
            // 
            NotesLabel.AutoSize = true;
            NotesLabel.Location = new Point(324, 225);
            NotesLabel.Name = "NotesLabel";
            NotesLabel.Size = new Size(56, 15);
            NotesLabel.TabIndex = 11;
            NotesLabel.Text = "Заметки:";
            // 
            // DelButton
            // 
            DelButton.Location = new Point(577, 379);
            DelButton.Name = "DelButton";
            DelButton.Size = new Size(75, 23);
            DelButton.TabIndex = 12;
            DelButton.Text = "Удалить";
            DelButton.UseVisualStyleBackColor = true;
            DelButton.Click += DelButton_Click;
            // 
            // GeneratePassButton
            // 
            GeneratePassButton.Location = new Point(410, 379);
            GeneratePassButton.Name = "GeneratePassButton";
            GeneratePassButton.Size = new Size(144, 23);
            GeneratePassButton.TabIndex = 13;
            GeneratePassButton.Text = "Сгенерировать пароль";
            GeneratePassButton.UseVisualStyleBackColor = true;
            GeneratePassButton.Click += GeneratePassButton_Click;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(324, 71);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(44, 15);
            LoginLabel.TabIndex = 14;
            LoginLabel.Text = "Логин:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(324, 132);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(52, 15);
            PasswordLabel.TabIndex = 15;
            PasswordLabel.Text = "Пароль:";
            // 
            // LogPassPanel
            // 
            LogPassPanel.Controls.Add(ServiceNameLabel);
            LogPassPanel.Controls.Add(LinkLabel);
            LogPassPanel.Location = new Point(296, 24);
            LogPassPanel.Name = "LogPassPanel";
            LogPassPanel.Size = new Size(379, 409);
            LogPassPanel.TabIndex = 16;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 445);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(GeneratePassButton);
            Controls.Add(DelButton);
            Controls.Add(NotesLabel);
            Controls.Add(NotesTextBox);
            Controls.Add(PassWordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(EntriesListBox);
            Controls.Add(MenuStrip);
            Controls.Add(LogPassPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuStrip;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Менеджер паролей";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            LogPassPanel.ResumeLayout(false);
            LogPassPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox EntriesListBox;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem FileMenuStrip;
        private Label ServiceNameLabel;
        private TextBox LoginTextBox;
        private TextBox PassWordTextBox;
        private TextBox textBox3;
        private TextBox NotesTextBox;
        private LinkLabel LinkLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label NotesLabel;
        private Button DelButton;
        private Button GeneratePassButton;
        private Label LoginLabel;
        private Label PasswordLabel;
        private Panel LogPassPanel;
        private ToolStripMenuItem AddMenuStrip;
        private ToolStripMenuItem EditMenuStrip;
    }
}
