namespace PasswordManager.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string EntriesFilePath)
        {
            entriesWorker = new EntriesWorker(EntriesFilePath);
            PasswordEntriesList = entriesWorker.LoadEntries();

            InitializeComponent();

            if (PasswordEntriesList != null)
                foreach (PasswordEntry entry in PasswordEntriesList)
                    PasswordsList.Items.Add(entry.PasswordName);
            else
                PasswordEntriesList = new List<PasswordEntry>();
        }

        private List<PasswordEntry> PasswordEntriesList = new List<PasswordEntry>();
        private EntriesWorker entriesWorker;

        private void AddMenuStrip_Click(object sender, EventArgs e)
        {
            CreateEditForm createEditForm = new CreateEditForm();
            DialogResult createResult = createEditForm.ShowDialog();

            if (createResult == DialogResult.OK)
            {
                PasswordEntriesList.Add(createEditForm.PasswordEntry);
                PasswordsList.Items.Add(createEditForm.PasswordEntry.PasswordName);
            }

        }
    }
}