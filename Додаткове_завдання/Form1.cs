namespace Додаткове_завдання
{
    public partial class MainForm : Form
    {
        private int searchFormCount = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(++searchFormCount);
            searchForm.FormClosed += SearchForm_FormClosed;
            searchForm.Show();
        }
        private void SearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SearchForm searchForm = sender as SearchForm;
            if (searchForm != null)
            {
                string[] files = searchForm.GetFiles();
                foreach (string file in files)
                {
                    listBox.Items.Add(file);
                }
            }
        }
    }
}