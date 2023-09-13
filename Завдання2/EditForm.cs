using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Завдання2
{
    public partial class EditForm : Form
    {
        public EditForm(string text)
        {
            InitializeComponent();
        }
        public string GetText()
        {
            return textBox.Text;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            textBox.Text = string.Empty;
            Close();
        }
    }
}
