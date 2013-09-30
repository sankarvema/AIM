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
    public partial class AlertForm : Form
    {
        public AlertForm()
        {
            InitializeComponent();
        }

        private void AlertForm_Load(object sender, EventArgs e)
        {
            this.MouseDoubleClick += new MouseEventHandler(AlertForm_MouseDoubleClick);
        }

        void AlertForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point scrn = PointToScreen(new Point(this.Top, this.Left));
            MessageBox.Show(string.Format("Position ({0},{1}), Width:{2}, Height={3}", scrn.X, scrn.Y , this.Width, this.Height));
            this.Top = 510;
            this.Left = 95;
        }
    }
}
