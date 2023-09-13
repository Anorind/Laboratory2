namespace Додаткове_завдання
{
    partial class SearchForm
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
            folderTextBox = new RichTextBox();
            browseButton = new Button();
            searchButton = new Button();
            maskTextBox = new TextBox();
            label1 = new Label();
            resultListBox = new ListBox();
            SuspendLayout();
            // 
            // folderTextBox
            // 
            folderTextBox.Location = new Point(23, 54);
            folderTextBox.Name = "folderTextBox";
            folderTextBox.Size = new Size(303, 243);
            folderTextBox.TabIndex = 0;
            folderTextBox.Text = "";
            // 
            // browseButton
            // 
            browseButton.Location = new Point(23, 313);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(263, 102);
            browseButton.TabIndex = 2;
            browseButton.Text = "Огляд";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(492, 313);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(263, 102);
            searchButton.TabIndex = 3;
            searchButton.Text = "Пошук";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // maskTextBox
            // 
            maskTextBox.Location = new Point(514, 16);
            maskTextBox.Name = "maskTextBox";
            maskTextBox.Size = new Size(241, 31);
            maskTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(372, 22);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 5;
            label1.Text = "Введіть маску";
            // 
            // resultListBox
            // 
            resultListBox.FormattingEnabled = true;
            resultListBox.ItemHeight = 25;
            resultListBox.Location = new Point(440, 56);
            resultListBox.Name = "resultListBox";
            resultListBox.Size = new Size(315, 229);
            resultListBox.TabIndex = 6;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultListBox);
            Controls.Add(label1);
            Controls.Add(maskTextBox);
            Controls.Add(searchButton);
            Controls.Add(browseButton);
            Controls.Add(folderTextBox);
            Name = "SearchForm";
            Text = "SearchForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox folderTextBox;
        private Button browseButton;
        private Button searchButton;
        private TextBox maskTextBox;
        private Label label1;
        private ListBox resultListBox;
    }
}