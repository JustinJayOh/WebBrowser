using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class TabBrowserControl : UserControl
    {
        // Fields
        Stack<string> backLinks = new Stack<string>();
        Stack<string> forwardLinks = new Stack<string>();
        string currentPage;
        bool navigated = false;

        public TabBrowserControl()
        {
            InitializeComponent();
        }

        private void goToolButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(addressTool.Text);
            currentPage = addressTool.Text;
            backLinks.Push(currentPage);
            AddHistoryItem(currentPage);
        }

        private void addressTool_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                goToolButton_Click(sender, e);
            }
        }

        private void refreshToolButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(currentPage);
        }

        private void backToolButton_Click(object sender, EventArgs e)
        {
            if (backLinks.Count > 0)
            {
                forwardLinks.Push(currentPage);
                string navigateTo = backLinks.Pop();
                webBrowser1.Navigate(navigateTo);
                addressTool.Text = navigateTo;
                currentPage = navigateTo;
                AddHistoryItem(currentPage);
            }
        }

        private void forwardToolButton_Click(object sender, EventArgs e)
        {
            if (forwardLinks.Count > 0)
            {
                backLinks.Push(currentPage);
                string navigateTo = forwardLinks.Pop();
                webBrowser1.Navigate(navigateTo);
                addressTool.Text = navigateTo;
                currentPage = navigateTo;
                AddHistoryItem(currentPage);
            }
        }

        private void bookmarkToolButton_Click(object sender, EventArgs e)
        {
            var item = new BookmarkItem();
            item.URL = currentPage;
            item.Title = getTitle(currentPage);

            var list = BookmarkManager.GetItems();
            if (!list.Contains(item))
            {
                BookmarkManager.AddItem(item);
            }
        }

        // Method to return a webpages title from its URL.
        private static string getTitle(string currentPage)
        {
            StringBuilder title = new StringBuilder();
            int countW = 0;
            int countPer = 0;

            for (int i = 0; i < currentPage.Length; i++)
            {
                if (countW == 3 && countPer == 1)
                {
                    title.Append(currentPage[i]);
                }
            }
            return title.ToString();
        }

        // Method to add a HistoryItem from a page's URL.
        private static void AddHistoryItem(string currentPage)
        {
            var time = DateTime.Now;
            var title = getTitle(currentPage);
            var item = new HistoryItem();
            item.URL = currentPage;
            item.Title = title;
            item.Date = time;
            HistoryManager.AddItem(item);
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (!(e.CurrentProgress <= 0 || e.CurrentProgress == e.MaximumProgress || e.CurrentProgress > 100))
            {
                progressBarToolStrip.Value = (int)e.CurrentProgress * 100 / (int)e.MaximumProgress;
                statusLabelToolStrip.Text = "Loading";
            }
            else
            {
                progressBarToolStrip.Value = 0;
                statusLabelToolStrip.Text = "Done";
            }
        }
    }
}
