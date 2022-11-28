namespace Task4
{
    partial class SearchWithManyCriteriaForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderNameTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.folderBrowserButton = new System.Windows.Forms.Button();
            this.byNameCheckBox = new System.Windows.Forms.CheckBox();
            this.bySizeCheckBox = new System.Windows.Forms.CheckBox();
            this.byLastWriteTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.sameFilesListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastWriteColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // folderNameTextBox
            // 
            this.folderNameTextBox.Location = new System.Drawing.Point(39, 31);
            this.folderNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.folderNameTextBox.Name = "folderNameTextBox";
            this.folderNameTextBox.Size = new System.Drawing.Size(325, 22);
            this.folderNameTextBox.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(162, 61);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 28);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // folderBrowserButton
            // 
            this.folderBrowserButton.Location = new System.Drawing.Point(388, 30);
            this.folderBrowserButton.Margin = new System.Windows.Forms.Padding(4);
            this.folderBrowserButton.Name = "folderBrowserButton";
            this.folderBrowserButton.Size = new System.Drawing.Size(100, 25);
            this.folderBrowserButton.TabIndex = 7;
            this.folderBrowserButton.Text = "...";
            this.folderBrowserButton.UseVisualStyleBackColor = true;
            this.folderBrowserButton.Click += new System.EventHandler(this.FolderBrowserButton_Click);
            // 
            // byNameCheckBox
            // 
            this.byNameCheckBox.AutoSize = true;
            this.byNameCheckBox.Location = new System.Drawing.Point(525, 14);
            this.byNameCheckBox.Name = "byNameCheckBox";
            this.byNameCheckBox.Size = new System.Drawing.Size(127, 20);
            this.byNameCheckBox.TabIndex = 10;
            this.byNameCheckBox.Text = "Search by name";
            this.byNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // bySizeCheckBox
            // 
            this.bySizeCheckBox.AutoSize = true;
            this.bySizeCheckBox.Location = new System.Drawing.Point(525, 40);
            this.bySizeCheckBox.Name = "bySizeCheckBox";
            this.bySizeCheckBox.Size = new System.Drawing.Size(117, 20);
            this.bySizeCheckBox.TabIndex = 11;
            this.bySizeCheckBox.Text = "Search by size";
            this.bySizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // byLastWriteTimeCheckBox
            // 
            this.byLastWriteTimeCheckBox.AutoSize = true;
            this.byLastWriteTimeCheckBox.Location = new System.Drawing.Point(525, 66);
            this.byLastWriteTimeCheckBox.Name = "byLastWriteTimeCheckBox";
            this.byLastWriteTimeCheckBox.Size = new System.Drawing.Size(172, 20);
            this.byLastWriteTimeCheckBox.TabIndex = 12;
            this.byLastWriteTimeCheckBox.Text = "Search by last write time";
            this.byLastWriteTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // sameFilesListView
            // 
            this.sameFilesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sameFilesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.pathColumn,
            this.sizeColumn,
            this.lastWriteColumn});
            this.sameFilesListView.HideSelection = false;
            this.sameFilesListView.Location = new System.Drawing.Point(12, 101);
            this.sameFilesListView.Name = "sameFilesListView";
            this.sameFilesListView.Size = new System.Drawing.Size(923, 337);
            this.sameFilesListView.TabIndex = 13;
            this.sameFilesListView.UseCompatibleStateImageBehavior = false;
            this.sameFilesListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            // 
            // pathColumn
            // 
            this.pathColumn.Text = "Path";
            // 
            // sizeColumn
            // 
            this.sizeColumn.Text = "Size (Byte)";
            // 
            // lastWriteColumn
            // 
            this.lastWriteColumn.Text = "Last write time";
            // 
            // SearchWithManyCriteriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.sameFilesListView);
            this.Controls.Add(this.byLastWriteTimeCheckBox);
            this.Controls.Add(this.bySizeCheckBox);
            this.Controls.Add(this.byNameCheckBox);
            this.Controls.Add(this.folderNameTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.folderBrowserButton);
            this.Name = "SearchWithManyCriteriaForm";
            this.Text = "SearchWithManyCriteriaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderNameTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button folderBrowserButton;
        private System.Windows.Forms.CheckBox byNameCheckBox;
        private System.Windows.Forms.CheckBox bySizeCheckBox;
        private System.Windows.Forms.CheckBox byLastWriteTimeCheckBox;
        private System.Windows.Forms.ListView sameFilesListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader pathColumn;
        private System.Windows.Forms.ColumnHeader sizeColumn;
        private System.Windows.Forms.ColumnHeader lastWriteColumn;
    }
}

