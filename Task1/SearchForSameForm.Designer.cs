namespace Task1
{
    partial class SearchForSameForm
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
            this.folderBrowserButton = new System.Windows.Forms.Button();
            this.sameFilesTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderNameTextBox
            // 
            this.folderNameTextBox.Location = new System.Drawing.Point(16, 12);
            this.folderNameTextBox.Name = "folderNameTextBox";
            this.folderNameTextBox.Size = new System.Drawing.Size(182, 20);
            this.folderNameTextBox.TabIndex = 0;
            // 
            // folderBrowserButton
            // 
            this.folderBrowserButton.Location = new System.Drawing.Point(16, 64);
            this.folderBrowserButton.Name = "folderBrowserButton";
            this.folderBrowserButton.Size = new System.Drawing.Size(75, 22);
            this.folderBrowserButton.TabIndex = 1;
            this.folderBrowserButton.Text = "...";
            this.folderBrowserButton.UseVisualStyleBackColor = true;
            this.folderBrowserButton.Click += new System.EventHandler(this.FolderBrowserButton_Click);
            // 
            // sameFilesTextBox
            // 
            this.sameFilesTextBox.Location = new System.Drawing.Point(225, 12);
            this.sameFilesTextBox.Multiline = true;
            this.sameFilesTextBox.Name = "sameFilesTextBox";
            this.sameFilesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sameFilesTextBox.Size = new System.Drawing.Size(501, 426);
            this.sameFilesTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(123, 62);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchForSameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.sameFilesTextBox);
            this.Controls.Add(this.folderBrowserButton);
            this.Controls.Add(this.folderNameTextBox);
            this.Name = "SearchForSameForm";
            this.Text = "SearchForSimilarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderNameTextBox;
        private System.Windows.Forms.Button folderBrowserButton;
        private System.Windows.Forms.TextBox sameFilesTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}

