using System;
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
    public partial class History_Manager_Form : Form
    {
        public History_Manager_Form()
        {
            InitializeComponent();
        }

        private void History_Manager_Form_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            historyListBox.Items.Clear();
            foreach (var item in items)
            {
                historyListBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
            }
        }

        private void historySearchButton_Click(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            historyListBox.Items.Clear();
            foreach (var item in items)
            {
                if (item.Title.Contains(historySearchTextBox.Text) || item.URL.Contains(historySearchTextBox.Text))
                {
                    historyListBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
                }
            }
        }

        private void historyDeleteButton_Click(object sender, EventArgs e)
        {
            if (historyListBox.SelectedItem != null)
            {
                int selectedIndex = historyListBox.SelectedIndex;
                HistoryManager.DeleteItem(selectedIndex);
                historyListBox.Items.Clear();
                var items = HistoryManager.GetItems();
                foreach (var item in items)
                {
                    historyListBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
                }
            }
        }

        private void historyClearButton_Click(object sender, EventArgs e)
        {
            HistoryManager.Clear();
            historyListBox.Items.Clear();
        }
    }
}
