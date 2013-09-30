using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace ARApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Global.MainForm = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.DoubleClick +=new EventHandler(MainForm_DoubleClick);


            // Load emulator image
            pictureBox1.Image = Image.FromFile(Properties.Settings.Default.ContentPath + @"\emulator-image.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Show();
        }

        ScriptManager mgr = null;
        private void InitAction()
        {
            mgr = new ScriptManager();


            this.DoubleClick += new EventHandler(MainForm_DoubleClick);
            axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(0);
            axWindowsMediaPlayer1.Padding = new System.Windows.Forms.Padding(0);
            axWindowsMediaPlayer1.URL = Properties.Settings.Default.ContentPath + Properties.Settings.Default.MainVid;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.Ctlenabled = false;
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.Top = 30;
            axWindowsMediaPlayer1.Left = 50;
            axWindowsMediaPlayer1.Height = 300;
            axWindowsMediaPlayer1.Width = 550;
            axWindowsMediaPlayer1.stretchToFit = true;

            //mgr.PlayScript();
        }

        void MainForm_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("Double clicked");
            InitAction();
        }

        //ScriptManager mgr 
        private void button1_Click(object sender, EventArgs e)
        {
            mgr.PerformNextAct();
        }

        int clickCount = 0;
        JobSheet js = null;
        private void button2_Click(object sender, EventArgs e)
        {
            
            switch (clickCount)
            {
                case 0:
                    
                    js = new JobSheet();
                    js.Left = 80;
                    js.Top = 40;
                    js.Show();
                    break;

                case 1:
                    js.jobChkList.SetItemCheckState(1, CheckState.Checked);
                    break;

                case 2:
                    js.jobChkList.SetItemCheckState(2, CheckState.Indeterminate);
                    break;

                case 3:
                    js.jobChkList.SetItemCheckState(0, CheckState.Checked);
                    break;

                case 4:
                    js.jobChkList.Visible = false;
                    js.lblSubmitting.Visible = true;
                    js.BringToFront();
                    Task.Factory.StartNew(() =>
                    {
                        Thread.Sleep(2000);
                        this.Invoke(new Action(() => ShowSubmitted()));
                    });

                    break;

                case 5:
                    js.Hide();
                    break;
            }
            js.BringToFront();
            clickCount++;
        }

        private void  ShowSubmitted()
        {
            js.lblSubmitting.Visible = false;
            js.lblSubmitted.Visible = true;
        }
    }
}
