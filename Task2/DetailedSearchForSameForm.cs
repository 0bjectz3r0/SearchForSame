using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Task2
{
    public partial class DetailedSearchForSameForm : Form
    {
        public DetailedSearchForSameForm()
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
            catch (Exception ex) { MessageBox.Show(ex.Message, "Warning!"); }
            return files;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            sameFilesListView.Items.Clear();
            var files = GetFiles(folderNameTextBox.Text);
            var list = files.GroupBy(file => file.Name).Where(file => file.Count() > 1);
            foreach (var group in list)
            {
                var listGroup = new ListViewGroup(group.Key);
                sameFilesListView.Groups.Add(listGroup);
                foreach (var item in group)
                {
                    var listItem = new ListViewItem(new string[] {
                        nameColumn.Name = item.Name,
                        pathColumn.Name = item.FullName,
                        sizeColumn.Name = item.Length.ToString(),
                        lastWriteColumn.Name = item.LastWriteTime.ToString()
                    }, listGroup);
                    sameFilesListView.Items.Add(listItem);
                }
            }
            sameFilesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
