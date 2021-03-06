﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class Bookmark_Manager_Form : Form
    {
        public Bookmark_Manager_Form()
        {
            InitializeComponent();
        }

        private void Bookmark_Manager_Form_Load(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            bookmarkListBox.Items.Clear();
            foreach (var item in items)
            {
                bookmarkListBox.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
            }
        }

        private void bookmarkSearchButton_Click(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            bookmarkListBox.Items.Clear();
            foreach (var item in items)
            {
                if (item.Title.Contains(bookmarkSearchTextBox.Text) || item.URL.Contains(bookmarkSearchTextBox.Text))
                {
                    bookmarkListBox.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
                }
            }
        }

        private void bookmarkDeleteButton_Click(object sender, EventArgs e)
        {
            if (bookmarkListBox.SelectedItem != null)
            {
                int selectedIndex = bookmarkListBox.SelectedIndex;
                BookmarkManager.DeleteItem(selectedIndex);
                bookmarkListBox.Items.Clear();
                var items = BookmarkManager.GetItems();
                foreach (var item in items)
                {
                    bookmarkListBox.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
                }
            }
        }
    }
}
