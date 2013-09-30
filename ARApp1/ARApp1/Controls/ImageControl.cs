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
    public partial class ImageControl : UserControl, ControlInterface
    {
        public TransparentPicture Pic = new TransparentPicture();
        //public PictureBox Pic = new PictureBox();
        public ImageControl()
        {
            InitializeComponent();

            this.Pic.Location = new System.Drawing.Point(0, 0);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(24, 24);
            this.Pic.TabIndex = 1;
            this.Pic.TabStop = false;

            this.Controls.Add(Pic);

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;

        }


        public void Do()
        {
            //throw new NotImplementedException();
        }

        private void ImageControl_Load(object sender, EventArgs e)
        {
            //this.Pic.IsTransparent = true;
        }
    }
}
