using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ARApp1
{
    public partial class SearchForm : Form
    {
        public string SearchKey { get; set; }
        public string Result { get; set; }
        public SearchForm()
        {
            InitializeComponent();
        }

        public void Search()
        {
            pictureBox1.Image = Image.FromFile( Properties.Settings.Default.ContentPath + @"\SearchIcon.png");
            txtSearch.Text = SearchKey;
            lblSearch.Text = "Init visual search...";
            System.Threading.Thread.Sleep(1000);
            lblSearch.Text = "Searching...";
            System.Threading.Thread.Sleep(1000);
            lblSearch.Text = Result;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.Magenta;
            //this.TransparencyKey = Color.Magenta;
        }
    }
}
