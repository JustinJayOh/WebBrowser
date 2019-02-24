namespace WebBrowser.UI
{
    partial class TabBrowserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabBrowserControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.backToolButton = new System.Windows.Forms.ToolStripButton();
            this.forwardToolButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolButton = new System.Windows.Forms.ToolStripButton();
            this.homeToolButton = new System.Windows.Forms.ToolStripButton();
            this.addressTool = new System.Windows.Forms.ToolStripTextBox();
            this.goToolButton = new System.Windows.Forms.ToolStripButton();
            this.bookmarkToolButton = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBarToolStrip = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabelToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolButton,
            this.forwardToolButton,
            this.refreshToolButton,
            this.homeToolButton,
            this.addressTool,
            this.goToolButton,
            this.bookmarkToolButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1025, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // backToolButton
            // 
            this.backToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backToolButton.Image = ((System.Drawing.Image)(resources.GetObject("backToolButton.Image")));
            this.backToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backToolButton.Name = "backToolButton";
            this.backToolButton.Size = new System.Drawing.Size(24, 24);
            this.backToolButton.Text = "Back";
            this.backToolButton.Click += new System.EventHandler(this.backToolButton_Click);
            // 
            // forwardToolButton
            // 
            this.forwardToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardToolButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardToolButton.Image")));
            this.forwardToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardToolButton.Name = "forwardToolButton";
            this.forwardToolButton.Size = new System.Drawing.Size(24, 24);
            this.forwardToolButton.Text = "Forward";
            this.forwardToolButton.Click += new System.EventHandler(this.forwardToolButton_Click);
            // 
            // refreshToolButton
            // 
            this.refreshToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshToolButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolButton.Image")));
            this.refreshToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshToolButton.Name = "refreshToolButton";
            this.refreshToolButton.Size = new System.Drawing.Size(24, 24);
            this.refreshToolButton.Text = "Refresh";
            this.refreshToolButton.Click += new System.EventHandler(this.refreshToolButton_Click);
            // 
            // homeToolButton
            // 
            this.homeToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeToolButton.Image = ((System.Drawing.Image)(resources.GetObject("homeToolButton.Image")));
            this.homeToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeToolButton.Name = "homeToolButton";
            this.homeToolButton.Size = new System.Drawing.Size(24, 24);
            this.homeToolButton.Text = "Home";
            // 
            // addressTool
            // 
            this.addressTool.Name = "addressTool";
            this.addressTool.Size = new System.Drawing.Size(750, 27);
            this.addressTool.KeyUp += new System.Windows.Forms.KeyEventHandler(this.addressTool_KeyUp);
            // 
            // goToolButton
            // 
            this.goToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goToolButton.Image = ((System.Drawing.Image)(resources.GetObject("goToolButton.Image")));
            this.goToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goToolButton.Name = "goToolButton";
            this.goToolButton.Size = new System.Drawing.Size(24, 24);
            this.goToolButton.Text = "toolStripButton5";
            this.goToolButton.Click += new System.EventHandler(this.goToolButton_Click);
            // 
            // bookmarkToolButton
            // 
            this.bookmarkToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookmarkToolButton.Image = ((System.Drawing.Image)(resources.GetObject("bookmarkToolButton.Image")));
            this.bookmarkToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookmarkToolButton.Name = "bookmarkToolButton";
            this.bookmarkToolButton.Size = new System.Drawing.Size(24, 24);
            this.bookmarkToolButton.Text = "Bookmarks";
            this.bookmarkToolButton.Click += new System.EventHandler(this.bookmarkToolButton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 27);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1025, 602);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBarToolStrip,
            this.statusLabelToolStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 605);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1025, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBarToolStrip
            // 
            this.progressBarToolStrip.Name = "progressBarToolStrip";
            this.progressBarToolStrip.Size = new System.Drawing.Size(200, 18);
            // 
            // statusLabelToolStrip
            // 
            this.statusLabelToolStrip.Name = "statusLabelToolStrip";
            this.statusLabelToolStrip.Size = new System.Drawing.Size(0, 19);
            // 
            // TabBrowserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TabBrowserControl";
            this.Size = new System.Drawing.Size(1025, 629);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton backToolButton;
        private System.Windows.Forms.ToolStripButton forwardToolButton;
        private System.Windows.Forms.ToolStripButton refreshToolButton;
        private System.Windows.Forms.ToolStripButton homeToolButton;
        private System.Windows.Forms.ToolStripButton goToolButton;
        private System.Windows.Forms.ToolStripButton bookmarkToolButton;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.WebBrowser webBrowser1;
        public System.Windows.Forms.ToolStripTextBox addressTool;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBarToolStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelToolStrip;
    }
}
