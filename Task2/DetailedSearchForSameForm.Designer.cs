namespace Task2
{
    partial class DetailedSearchForSameForm
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
            this.sameFilesListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastWriteColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.folderNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.sameFilesListView.Location = new System.Drawing.Point(16, 82);
            this.sameFilesListView.Margin = new System.Windows.Forms.Padding(4);
            this.sameFilesListView.Name = "sameFilesListView";
            this.sameFilesListView.Size = new System.Drawing.Size(1033, 457);
            this.sameFilesListView.TabIndex = 0;
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
            this.lastWriteColumn.Text = "Last write";
            // 
            // folderBrowserButton
            // 
            this.folderBrowserButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.folderBrowserButton.Location = new System.Drawing.Point(713, 15);
            this.folderBrowserButton.Margin = new System.Windows.Forms.Padding(4);
            this.folderBrowserButton.Name = "folderBrowserButton";
            this.folderBrowserButton.Size = new System.Drawing.Size(100, 25);
            this.folderBrowserButton.TabIndex = 1;
            this.folderBrowserButton.Text = "...";
            this.folderBrowserButton.UseVisualStyleBackColor = true;
            this.folderBrowserButton.Click += new System.EventHandler(this.FolderBrowserButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchButton.Location = new System.Drawing.Point(479, 46);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 28);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // folderNameTextBox
            // 
            this.folderNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.folderNameTextBox.Location = new System.Drawing.Point(364, 16);
            this.folderNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.folderNameTextBox.Name = "folderNameTextBox";
            this.folderNameTextBox.Size = new System.Drawing.Size(325, 22);
            this.folderNameTextBox.TabIndex = 3;
            // 
            // DetailedSearchForSameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.folderNameTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.folderBrowserButton);
            this.Controls.Add(this.sameFilesListView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DetailedSearchForSameForm";
            this.Text = "DetailedSearchForSameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView sameFilesListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader pathColumn;
        private System.Windows.Forms.ColumnHeader sizeColumn;
        private System.Windows.Forms.ColumnHeader lastWriteColumn;
        private System.Windows.Forms.Button folderBrowserButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox folderNameTextBox;
    }
}

