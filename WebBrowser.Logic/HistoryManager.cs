using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.WebBrowserDBDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class HistoryManager
    {
        // Static Fields
        public static HistoryTableAdapter adapter = new HistoryTableAdapter();

        // Method to add a history item to the database
        public static void AddItem(HistoryItem item)
        {
            adapter.Insert(item.URL, item.Title, item.Date);
        }

        // Method to get a list of history items from the database
        public static List<HistoryItem> GetItems()
        {
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();
            foreach (var row in rows)
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;
                item.Id = row.Id;
                results.Add(item);
            }
            return results;
        }

        // Method to return one history item from the database
        public static HistoryItem GetItem(int index)
        {
            int i = 0;
            var rows = adapter.GetData();
            var item = new HistoryItem();
            foreach (var row in rows)
            {
                if (i == index)
                {
                    item.URL = row.URL;
                    item.Title = row.Title;
                    item.Date = row.Date;
                    item.Id = row.Id;
                }
                i++;
            }
            return item;
        }

        // Method to delete history item from the database
        public static void DeleteItem(int index)
        {
            HistoryItem item = GetItem(index);
            adapter.Delete(item.Id, item.URL, item.Title, item.Date);
        }

        // Method to delete all history items from the database
        public static void Clear()
        {
            var items = adapter.GetData();
            foreach (var item in items)
            {
                adapter.Delete(item.Id, item.URL, item.Title, item.Date);
            }
        }

        
    }
}
