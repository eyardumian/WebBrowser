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
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            foreach (var item in items)
            {
                HistoryListBox.Items.Add(string.Format("{0} ({1}) [{2}]", item.Title, item.URL, item.Date));
            }
        }

        private void ClearHistoryButton_Click(object sender, EventArgs e)
        {
            HistoryListBox.Items.Clear();
        }

        private void RemoveHistoryButton_Click(object sender, EventArgs e)
        {
            var chosen = HistoryListBox.SelectedIndex;
            HistoryListBox.Items.RemoveAt(chosen);
        }
    }
}
