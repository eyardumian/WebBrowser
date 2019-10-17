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
using 

namespace WebBrowser.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var historyItem = new HistoryManagerForm();
            historyItem.ShowDialog();
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bookmarkItem = new BookmarkManagerForm();
            bookmarkItem.ShowDialog();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void savePageAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowserUserControl1.webBrowser1.ShowSaveAsDialog();
        }
    }
}
