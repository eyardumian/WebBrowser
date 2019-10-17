namespace WebBrowser.UI
{
    partial class BookmarkManagerForm
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
            this.BookmarkListBox = new System.Windows.Forms.ListBox();
            this.BookmarkSearchTextBox = new System.Windows.Forms.TextBox();
            this.BookmarkSearchButton = new System.Windows.Forms.Button();
            this.RemoveBookmarkButton = new System.Windows.Forms.Button();
            this.ClearBookmarksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookmarkListBox
            // 
            this.BookmarkListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.BookmarkListBox.FormattingEnabled = true;
            this.BookmarkListBox.Location = new System.Drawing.Point(0, 0);
            this.BookmarkListBox.Name = "BookmarkListBox";
            this.BookmarkListBox.Size = new System.Drawing.Size(349, 450);
            this.BookmarkListBox.TabIndex = 0;
            // 
            // BookmarkSearchTextBox
            // 
            this.BookmarkSearchTextBox.Location = new System.Drawing.Point(378, 100);
            this.BookmarkSearchTextBox.Multiline = true;
            this.BookmarkSearchTextBox.Name = "BookmarkSearchTextBox";
            this.BookmarkSearchTextBox.Size = new System.Drawing.Size(187, 34);
            this.BookmarkSearchTextBox.TabIndex = 1;
            // 
            // BookmarkSearchButton
            // 
            this.BookmarkSearchButton.Location = new System.Drawing.Point(612, 100);
            this.BookmarkSearchButton.Name = "BookmarkSearchButton";
            this.BookmarkSearchButton.Size = new System.Drawing.Size(82, 34);
            this.BookmarkSearchButton.TabIndex = 2;
            this.BookmarkSearchButton.Text = "Search";
            this.BookmarkSearchButton.UseVisualStyleBackColor = true;
            // 
            // RemoveBookmarkButton
            // 
            this.RemoveBookmarkButton.Location = new System.Drawing.Point(427, 170);
            this.RemoveBookmarkButton.Name = "RemoveBookmarkButton";
            this.RemoveBookmarkButton.Size = new System.Drawing.Size(138, 34);
            this.RemoveBookmarkButton.TabIndex = 3;
            this.RemoveBookmarkButton.Text = "Remove Item";
            this.RemoveBookmarkButton.UseVisualStyleBackColor = true;
            this.RemoveBookmarkButton.Click += new System.EventHandler(this.RemoveBookmarkButton_Click);
            // 
            // ClearBookmarksButton
            // 
            this.ClearBookmarksButton.Location = new System.Drawing.Point(427, 237);
            this.ClearBookmarksButton.Name = "ClearBookmarksButton";
            this.ClearBookmarksButton.Size = new System.Drawing.Size(137, 38);
            this.ClearBookmarksButton.TabIndex = 4;
            this.ClearBookmarksButton.Text = "Clear Bookmarks";
            this.ClearBookmarksButton.UseVisualStyleBackColor = true;
            this.ClearBookmarksButton.Click += new System.EventHandler(this.ClearBookmarksButton_Click);
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearBookmarksButton);
            this.Controls.Add(this.RemoveBookmarkButton);
            this.Controls.Add(this.BookmarkSearchButton);
            this.Controls.Add(this.BookmarkSearchTextBox);
            this.Controls.Add(this.BookmarkListBox);
            this.Name = "BookmarkManagerForm";
            this.Text = "BookmarkManagerForm";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox BookmarkListBox;
        public System.Windows.Forms.TextBox BookmarkSearchTextBox;
        public System.Windows.Forms.Button BookmarkSearchButton;
        public System.Windows.Forms.Button RemoveBookmarkButton;
        public System.Windows.Forms.Button ClearBookmarksButton;
    }
}