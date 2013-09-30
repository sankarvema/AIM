using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WMPLib;

namespace ARApp1
{
    public partial class VideoForm : Form
    {
        public string VideoLink { get; set; }

        public VideoForm()
        {
            InitializeComponent();
        }

        private void VideoForm_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(0);
            axWindowsMediaPlayer1.Padding = new System.Windows.Forms.Padding(0);
            axWindowsMediaPlayer1.URL = VideoLink;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.Ctlenabled = false;
            axWindowsMediaPlayer1.uiMode = "none";
        }
    }
}
