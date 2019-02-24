using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.WebBrowserDBDataSetTableAdapters;


namespace WebBrowser.Logic
{
    public class BookmarkManager
    {
        // Static Field
        public static BookmarksTableAdapter adapter = new BookmarksTableAdapter();

        // Method to add BookmarkItem to database
        public static void AddItem(BookmarkItem item)
        {
            adapter.Insert(item.URL, item.Title);
        }

        // Method to get a list of BookmarkItems from the database
        public static List<BookmarkItem> GetItems()
        {
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();
            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.URL = row.URL;
                item.Title = row.Title;
                results.Add(item);
            }
            return results;
        }

        // Method to get one BookmarkItem from the database
        public static BookmarkItem GetItem(int index)
        {
            int i = 0;
            var rows = adapter.GetData();
            var item = new BookmarkItem();
            foreach (var row in rows)
            {
                if (i == index)
                {
                    item.Id = row.Id;
                    item.URL = row.URL;
                    item.Title = row.Title;
                }
                i++;
            }
            return item;
        }

        // Method to delete bookmarkItem from the database
        public static void DeleteItem(int index)
        {
            BookmarkItem item = GetItem(index);
            adapter.Delete(item.Id, item.URL, item.Title);
        }
    }
}
