using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Додаткове_завдання
{
    public partial class SearchForm : Form
    {
        private string[] files;
        public SearchForm(int number)
        {
            Text = "Пошук " + number;

            InitializeComponent();
        }
        public string[] GetFiles()
        {
            return files;
        }
        private void browseButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    folderTextBox.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string folderPath = folderTextBox.Text;
            string mask = "*";
            if (!string.IsNullOrEmpty(maskTextBox.Text))
            {
                mask += "." + maskTextBox.Text;
            }

            if (Directory.Exists(folderPath))
            {
                files = Directory.GetFiles(folderPath, mask, SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    resultListBox.Items.Add(file);
                }
                Close();
            }
            else
            {
                MessageBox.Show("Папка не существует");
            }
        }
    }
}

