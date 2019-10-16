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
    public partial class WebBrowserUserControl : UserControl
    {
        public WebBrowserUserControl()
        {
            InitializeComponent();
        }

        private void Navigate(string address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowser1.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Navigate(SearchTextBox.Text.ToString());

            var histItem = new HistoryItem();
            histItem.URL = SearchTextBox.Text;
            histItem.Title = webBrowser1.DocumentTitle;
            histItem.Date = DateTime.Now;
            HistoryManager.AddItem(histItem);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var newItem = new BookmarkItem();
            newItem.URL = SearchTextBox.Text;
            newItem.Title = webBrowser1.DocumentTitle;
            BookmarkManager.AddItem(newItem);
        }
    }
}
