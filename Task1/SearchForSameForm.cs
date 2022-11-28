using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Task1
{
    public partial class SearchForSameForm : Form
    {
        public SearchForSameForm()
        {
            InitializeComponent();
        }

        private void FolderBrowserButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            folderNameTextBox.Text = dialog.SelectedPath;
        }

        private List<FileInfo> GetFiles(string path)
        {
            var files = new List<FileInfo>();
            try
            {
                var directory = new DirectoryInfo(path);
                files.AddRange(directory.GetFiles());
                foreach (var subdirectory in Directory.GetDirectories(path))
                {
                    files.AddRange(GetFiles(subdirectory));
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
            return files;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            sameFilesTextBox.Clear();
            var files = GetFiles(folderNameTextBox.Text);
            var list = files.GroupBy(file => file.Name).Where(group => group.Count() > 1);
            foreach (var group in list)
            {
                sameFilesTextBox.AppendText(group.Key + "\r\n");
                foreach (var item in group)
                {
                    sameFilesTextBox.AppendText($"\t- {item.FullName}\r\n");
                }
                sameFilesTextBox.AppendText("\r\n");
            }
        }
    }
}
