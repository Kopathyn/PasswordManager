namespace PasswordManager.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(EntriesList list)
        {
            InitializeComponent();

            AllEntries = list;

            if (AllEntries.Entries != null)
                foreach (PasswordEntry entry in AllEntries.Entries)
                    EntriesListBox.Items.Add(entry.PasswordName);
            else
                AllEntries = new EntriesList();
        }

        public EntriesList AllEntries = new EntriesList();

        private void AddMenuStrip_Click(object sender, EventArgs e)
        {
            CreateEditForm createEditForm = new CreateEditForm();
            DialogResult createResult = createEditForm.ShowDialog();

            if (createResult == DialogResult.OK)
            {
                if (!AllEntries.isNameExists(createEditForm.passwordEntry.PasswordName))
                {
                    EntriesListBox.Items.Add(createEditForm.passwordEntry.PasswordName);
                    AllEntries.Add(createEditForm.passwordEntry);
                }
                else
                    MessageBox.Show("Запись с таким именем уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasswordsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EntriesListBox.SelectedIndex != -1)
            {
                var currentSelectedEntry = AllEntries.FindEntryByName(EntriesListBox.SelectedItem.ToString());
                if (currentSelectedEntry != null)
                {
                    ServiceNameLabel.Text = currentSelectedEntry.PasswordName;
                    ServiceNameLabel.Visible = true;
                    LoginTextBox.Text = currentSelectedEntry.Login;
                    PassWordTextBox.Text = currentSelectedEntry.Password;
                    NotesTextBox.Text = currentSelectedEntry.Notes;

                    if (currentSelectedEntry.ServiceLink != null)
                    {
                        LinkLabel.Text = currentSelectedEntry.ServiceLink;
                        LinkLabel.Visible = true;
                    }
                    else
                        LinkLabel.Visible = false;
                }
                else
                    MessageBox.Show("Запись с данным именем не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ServiceNameLabel.Text = null;
                ServiceNameLabel.Visible = false;
                LoginTextBox.Text = null;
                PassWordTextBox.Text = null;
                NotesTextBox.Text = null;
                LinkLabel.Text = null;
                LinkLabel.Visible = false;
            }
        }

        private void GeneratePassButton_Click(object sender, EventArgs e)
        {
            if (EntriesListBox.SelectedIndex != -1)
            {
                PassWordTextBox.Text = PasswordGenerator.GeneratePassword();

                int entryIndex = AllEntries.FindEntryNum(EntriesListBox.SelectedItem.ToString());
                AllEntries.Entries[entryIndex].Password = PassWordTextBox.Text;
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (EntriesListBox.SelectedIndex != -1)
            {
                DialogResult DeleteQuestion = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DeleteQuestion == DialogResult.Yes)
                {
                    int realIndex = AllEntries.FindEntryNum(EntriesListBox.SelectedItem.ToString());

                    if (realIndex != -1)
                    {
                        AllEntries.RemoveEntry(realIndex);
                        EntriesListBox.Items.RemoveAt(EntriesListBox.SelectedIndex);

                        MessageBox.Show("Запись удалена!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Запись не найдена в списке!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Ни одна запись не выбрана!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditMenuStrip_Click(object sender, EventArgs e)
        {
            if (EntriesListBox.SelectedIndex != -1)
            {
                CreateEditForm createEditForm = new CreateEditForm();
                PasswordEntry oldEntry = AllEntries.FindEntryByName(EntriesListBox.SelectedItem.ToString());

                createEditForm.passwordEntry = oldEntry;

                DialogResult createResult = createEditForm.ShowDialog();

                if (createResult == DialogResult.OK)
                {
                    PasswordEntry editedEntry = createEditForm.passwordEntry;

                    AllEntries.ReplaceEntries(oldEntry, editedEntry);

                    EntriesListBox.Items.RemoveAt(EntriesListBox.SelectedIndex);
                    EntriesListBox.Items.Add(editedEntry.PasswordName);
                }
            }
            else
                MessageBox.Show("Ни одна запись не выбрана", "Редактирование", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult closingForm = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (closingForm == DialogResult.Yes)
                this.Close();
        }
    }
}