using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Task3
{
    public partial class SearchWithCriterionForm : Form
    {
        public SearchWithCriterionForm()
        {
            InitializeComponent();
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
            if (byNameRadioButton.Checked)
            {
                var list = files.GroupBy(file => file.Name).Where(file => file.Count() > 1);
                foreach (var group in list)
                {
                    FillListView(group);
                }
            }
            else if (bySizeRadioButton.Checked)
            {
                var list = files.GroupBy(file => file.Length.ToString()).Where(file => file.Count() > 1);
                foreach (var group in list)
                {
                    FillListView(group);
                }
            }
            else if (byLastWriteRadioButton.Checked) 
            {
                var list = files.GroupBy(file => file.LastWriteTime.ToString()).Where(file => file.Count() > 1);
                foreach (var group in list)
                {
                    FillListView(group);
                }
            }
            sameFilesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void FillListView(IGrouping<string, FileInfo> group)
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

        private void FolderBrowserButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            folderNameTextBox.Text = dialog.SelectedPath;
        }
    }
}
