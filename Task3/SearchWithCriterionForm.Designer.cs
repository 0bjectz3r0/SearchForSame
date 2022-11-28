namespace Task3
{
    partial class SearchWithCriterionForm
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
            this.sameFilesListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastWriteColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.byNameRadioButton = new System.Windows.Forms.RadioButton();
            this.bySizeRadioButton = new System.Windows.Forms.RadioButton();
            this.byLastWriteRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // folderNameTextBox
            // 
            this.folderNameTextBox.Location = new System.Drawing.Point(14, 29);
            this.folderNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.folderNameTextBox.Name = "folderNameTextBox";
            this.folderNameTextBox.Size = new System.Drawing.Size(325, 22);
            this.folderNameTextBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(137, 59);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 28);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // folderBrowserButton
            // 
            this.folderBrowserButton.Location = new System.Drawing.Point(363, 28);
            this.folderBrowserButton.Margin = new System.Windows.Forms.Padding(4);
            this.folderBrowserButton.Name = "folderBrowserButton";
            this.folderBrowserButton.Size = new System.Drawing.Size(100, 25);
            this.folderBrowserButton.TabIndex = 4;
            this.folderBrowserButton.Text = "...";
            this.folderBrowserButton.UseVisualStyleBackColor = true;
            this.folderBrowserButton.Click += new System.EventHandler(this.FolderBrowserButton_Click);
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
            this.sameFilesListView.Location = new System.Drawing.Point(12, 93);
            this.sameFilesListView.Name = "sameFilesListView";
            this.sameFilesListView.Size = new System.Drawing.Size(899, 386);
            this.sameFilesListView.TabIndex = 7;
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
            // byNameRadioButton
            // 
            this.byNameRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.byNameRadioButton.AutoSize = true;
            this.byNameRadioButton.Checked = true;
            this.byNameRadioButton.Location = new System.Drawing.Point(526, 12);
            this.byNameRadioButton.Name = "byNameRadioButton";
            this.byNameRadioButton.Size = new System.Drawing.Size(126, 20);
            this.byNameRadioButton.TabIndex = 8;
            this.byNameRadioButton.TabStop = true;
            this.byNameRadioButton.Text = "Search by name";
            this.byNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // bySizeRadioButton
            // 
            this.bySizeRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bySizeRadioButton.AutoSize = true;
            this.bySizeRadioButton.Location = new System.Drawing.Point(526, 36);
            this.bySizeRadioButton.Name = "bySizeRadioButton";
            this.bySizeRadioButton.Size = new System.Drawing.Size(116, 20);
            this.bySizeRadioButton.TabIndex = 9;
            this.bySizeRadioButton.Text = "Search by size";
            this.bySizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // byLastWriteRadioButton
            // 
            this.byLastWriteRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.byLastWriteRadioButton.AutoSize = true;
            this.byLastWriteRadioButton.Location = new System.Drawing.Point(526, 59);
            this.byLastWriteRadioButton.Name = "byLastWriteRadioButton";
            this.byLastWriteRadioButton.Size = new System.Drawing.Size(171, 20);
            this.byLastWriteRadioButton.TabIndex = 10;
            this.byLastWriteRadioButton.Text = "Search by last write time";
            this.byLastWriteRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchWithCriterionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 491);
            this.Controls.Add(this.byLastWriteRadioButton);
            this.Controls.Add(this.bySizeRadioButton);
            this.Controls.Add(this.byNameRadioButton);
            this.Controls.Add(this.sameFilesListView);
            this.Controls.Add(this.folderNameTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.folderBrowserButton);
            this.Name = "SearchWithCriterionForm";
            this.Text = "SearchWithCriterionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderNameTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button folderBrowserButton;
        private System.Windows.Forms.ListView sameFilesListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader pathColumn;
        private System.Windows.Forms.ColumnHeader sizeColumn;
        private System.Windows.Forms.ColumnHeader lastWriteColumn;
        private System.Windows.Forms.RadioButton byNameRadioButton;
        private System.Windows.Forms.RadioButton bySizeRadioButton;
        private System.Windows.Forms.RadioButton byLastWriteRadioButton;
    }
}

