namespace WebBrowser.UI
{
    partial class Bookmark_Manager_Form
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
            this.bookmarkListBox = new System.Windows.Forms.ListBox();
            this.bookmarkSearchTextBox = new System.Windows.Forms.TextBox();
            this.bookmarkSearchButton = new System.Windows.Forms.Button();
            this.bookmarkDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookmarkListBox
            // 
            this.bookmarkListBox.FormattingEnabled = true;
            this.bookmarkListBox.ItemHeight = 16;
            this.bookmarkListBox.Location = new System.Drawing.Point(0, 48);
            this.bookmarkListBox.Name = "bookmarkListBox";
            this.bookmarkListBox.Size = new System.Drawing.Size(800, 388);
            this.bookmarkListBox.TabIndex = 0;
            // 
            // bookmarkSearchTextBox
            // 
            this.bookmarkSearchTextBox.Location = new System.Drawing.Point(13, 13);
            this.bookmarkSearchTextBox.Name = "bookmarkSearchTextBox";
            this.bookmarkSearchTextBox.Size = new System.Drawing.Size(203, 22);
            this.bookmarkSearchTextBox.TabIndex = 1;
            // 
            // bookmarkSearchButton
            // 
            this.bookmarkSearchButton.Location = new System.Drawing.Point(222, 12);
            this.bookmarkSearchButton.Name = "bookmarkSearchButton";
            this.bookmarkSearchButton.Size = new System.Drawing.Size(75, 23);
            this.bookmarkSearchButton.TabIndex = 2;
            this.bookmarkSearchButton.Text = "Search";
            this.bookmarkSearchButton.UseVisualStyleBackColor = true;
            this.bookmarkSearchButton.Click += new System.EventHandler(this.bookmarkSearchButton_Click);
            // 
            // bookmarkDeleteButton
            // 
            this.bookmarkDeleteButton.Location = new System.Drawing.Point(303, 12);
            this.bookmarkDeleteButton.Name = "bookmarkDeleteButton";
            this.bookmarkDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.bookmarkDeleteButton.TabIndex = 3;
            this.bookmarkDeleteButton.Text = "Delete";
            this.bookmarkDeleteButton.UseVisualStyleBackColor = true;
            this.bookmarkDeleteButton.Click += new System.EventHandler(this.bookmarkDeleteButton_Click);
            // 
            // Bookmark_Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookmarkDeleteButton);
            this.Controls.Add(this.bookmarkSearchButton);
            this.Controls.Add(this.bookmarkSearchTextBox);
            this.Controls.Add(this.bookmarkListBox);
            this.Name = "Bookmark_Manager_Form";
            this.Text = "Bookmark_Manager_Form";
            this.Load += new System.EventHandler(this.Bookmark_Manager_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox bookmarkListBox;
        private System.Windows.Forms.TextBox bookmarkSearchTextBox;
        private System.Windows.Forms.Button bookmarkSearchButton;
        private System.Windows.Forms.Button bookmarkDeleteButton;
    }
}