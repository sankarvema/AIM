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
    public partial class SceneForm : Form
    {
        public string SceneLink { get; set; }
        public Size SceneSize { get; set; }

        public SceneForm()
        {
            InitializeComponent();
            this.MouseDoubleClick += new MouseEventHandler(SceneForm_MouseDoubleClick);
            this.axWindowsMediaPlayer1.MouseDownEvent += new AxWMPLib._WMPOCXEvents_MouseDownEventHandler(axWindowsMediaPlayer1_MouseDownEvent);
        }

        void axWindowsMediaPlayer1_MouseDownEvent(object sender, AxWMPLib._WMPOCXEvents_MouseDownEvent e)
        {
            Point p = axWindowsMediaPlayer1.PointToScreen(new Point(e.fX, e.fY));

            MessageBox.Show(String.Format("({0},{1})->({2},{3})", e.fX, e.fY,p.X, p.Y));
        }

        void SceneForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(String.Format("({0},{1})", e.X, e.Y));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ToDo:: Temp init
            SceneLink = @"D:\Sankar\01. Work\Adv Research\AR Framework\Scn01.Vid\compiling_01.avi";
            SceneSize = new Size(800,600);

            //this.BackColor = Color.Magenta;
            //this.TransparencyKey = Color.Magenta;
            this.Size = SceneSize;
            this.StartPosition = FormStartPosition.CenterScreen;


            ScriptManager mgr = new ScriptManager();

            axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(0);
            axWindowsMediaPlayer1.Padding = new System.Windows.Forms.Padding(0);
            axWindowsMediaPlayer1.URL = SceneLink;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.Ctlenabled = false;
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.Height = SceneSize.Height;
            axWindowsMediaPlayer1.Width = SceneSize.Width;
            axWindowsMediaPlayer1.stretchToFit = true;

            mgr.PlayScript();

        }
    }
}
