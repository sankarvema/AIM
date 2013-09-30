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
    public partial class TextScroll : Form
    {
        public string MessageText 
        { 
            get
            {
                return textBox1.Text;
            } 
            set
            {
                textBox1.Text += value;
            }
        }

        public TextScroll()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextScroll_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;

            
        }
    }
}
