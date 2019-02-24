namespace WebBrowser.UI
{
    partial class History_Manager_Form
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
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.historySearchTextBox = new System.Windows.Forms.TextBox();
            this.historySearchButton = new System.Windows.Forms.Button();
            this.historyDeleteButton = new System.Windows.Forms.Button();
            this.historyClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historyListBox
            // 
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 16;
            this.historyListBox.Location = new System.Drawing.Point(0, 44);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(800, 404);
            this.historyListBox.TabIndex = 0;
            // 
            // historySearchTextBox
            // 
            this.historySearchTextBox.Location = new System.Drawing.Point(12, 12);
            this.historySearchTextBox.Name = "historySearchTextBox";
            this.historySearchTextBox.Size = new System.Drawing.Size(203, 22);
            this.historySearchTextBox.TabIndex = 1;
            // 
            // historySearchButton
            // 
            this.historySearchButton.Location = new System.Drawing.Point(221, 11);
            this.historySearchButton.Name = "historySearchButton";
            this.historySearchButton.Size = new System.Drawing.Size(75, 23);
            this.historySearchButton.TabIndex = 2;
            this.historySearchButton.Text = "Search";
            this.historySearchButton.UseVisualStyleBackColor = true;
            this.historySearchButton.Click += new System.EventHandler(this.historySearchButton_Click);
            // 
            // historyDeleteButton
            // 
            this.historyDeleteButton.Location = new System.Drawing.Point(302, 11);
            this.historyDeleteButton.Name = "historyDeleteButton";
            this.historyDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.historyDeleteButton.TabIndex = 3;
            this.historyDeleteButton.Text = "Delete";
            this.historyDeleteButton.UseVisualStyleBackColor = true;
            this.historyDeleteButton.Click += new System.EventHandler(this.historyDeleteButton_Click);
            // 
            // historyClearButton
            // 
            this.historyClearButton.Location = new System.Drawing.Point(383, 11);
            this.historyClearButton.Name = "historyClearButton";
            this.historyClearButton.Size = new System.Drawing.Size(75, 23);
            this.historyClearButton.TabIndex = 4;
            this.historyClearButton.Text = "Clear";
            this.historyClearButton.UseVisualStyleBackColor = true;
            this.historyClearButton.Click += new System.EventHandler(this.historyClearButton_Click);
            // 
            // History_Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.historyClearButton);
            this.Controls.Add(this.historyDeleteButton);
            this.Controls.Add(this.historySearchButton);
            this.Controls.Add(this.historySearchTextBox);
            this.Controls.Add(this.historyListBox);
            this.Name = "History_Manager_Form";
            this.Text = "History_Manager_Form";
            this.Load += new System.EventHandler(this.History_Manager_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.TextBox historySearchTextBox;
        private System.Windows.Forms.Button historySearchButton;
        private System.Windows.Forms.Button historyDeleteButton;
        private System.Windows.Forms.Button historyClearButton;
    }
}