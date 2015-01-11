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
    public partial class VideoControl : UserControl, ControlInterface
    {
        public string VideoLink { get; set; }
        public VideoControl()
        {
            InitializeComponent();
        }

        public void Do()
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
