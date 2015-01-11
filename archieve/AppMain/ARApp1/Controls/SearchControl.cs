using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ARApp1
{
    public partial class SearchControl : UserControl, ControlInterface
    {
        public string SearchKey { get; set; }
        public string Result { get; set; }

        public SearchControl()
        {
            InitializeComponent();
        }

        public void Do()
        {
            pictureBox1.Image = Image.FromFile(Properties.Settings.Default.ContentPath + @"\Search-Icon.png");
            txtSearch.Text = SearchKey;
            lblSearch.Text = "Init visual search...";
            //System.Threading.Thread.Sleep(1000);
            lblSearch.Text = "Searching...";
            //System.Threading.Thread.Sleep(1000);
            lblSearch.Text = Result;
        }
    }
}
