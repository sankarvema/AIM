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
    public partial class ImageForm : Form
    {
        public string ImagePath { get; set; }

        public ImageForm()
        {
            InitializeComponent();
        }


        private void ImageForm_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;
            this.ShowInTaskbar = false;
        }
    }
}
