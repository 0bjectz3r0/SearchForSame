using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Task4
{
    public partial class SearchWithManyCriteriaForm : Form
    {
        public SearchWithManyCriteriaForm()
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

        private void FolderBrowserButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            folderNameTextBox.Text = dialog.SelectedPath;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            sameFilesListView.Items.Clear();
            var files = GetFiles(folderNameTextBox.Text);
            if (byNameCheckBox.Checked && bySizeCheckBox.Checked && byLastWriteTimeCheckBox.Checked)
            {
                var list = files.GroupBy(file => new { file.Name, file.Length, file.LastWriteTime }).Where(file => file.Count() > 1);
                foreach (var group in list)
                {
                    var listGroup = new ListViewGroup(group.Key.Name);
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
            }
            else if (byNameCheckBox.Checked && bySizeCheckBox.Checked)
            {
                var list = files.GroupBy(file => new { file.Name, file.Length }).Where(file => file.Count() > 1);
                foreach (var group in list)
                {
                    var listGroup = new ListViewGroup(group.Key.Name);
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
            }
            else if (byNameCheckBox.Checked && byLastWriteTimeCheckBox.Checked)
            {
                var list = files.GroupBy(file => new { file.Name, file.LastWriteTime }).Where(file => file.Count() > 1);
                foreach (var group in list)
                {
                    var listGroup = new ListViewGroup(group.Key.Name);
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
            }
            else if (byNameCheckBox.Checked && bySizeCheckBox.Checked)
            {
                var list = files.GroupBy(file => new { file.Length, file.LastWriteTime }).Where(file => file.Count() > 1);
                foreach (var group in list)
                {
                    var listGroup = new ListViewGroup($"Size: {group.Key.Length}");
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
            }
            else
            {
                MessageBox.Show("Please, select more criterias!!", "Warning");
                return;
            }
            sameFilesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
