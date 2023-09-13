namespace Завдання2
{
    public partial class MainForm : Form
    {
        private string filePath;
        public MainForm()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    richTextBox1.Text = File.ReadAllText(filePath);
                    editButton.Enabled = true;
                }
            }
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(richTextBox1.Text);
            editForm.FormClosed += EditForm_FormClosed;
            editForm.Show();
        }
        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            EditForm editForm = sender as EditForm;
            if (editForm != null)
            {
                richTextBox1.Text = editForm.GetText();
                File.WriteAllText(filePath, richTextBox1.Text);
            }
        }
    }
}