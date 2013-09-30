using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using mshtml;
using System.IO;

namespace ARApp1
{
    public partial class MessageForm : Form
    {
        IHTMLDocument2 doc;

        public MessageForm()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Move += new EventHandler(MessageForm_Move);
            this.MouseDoubleClick += new MouseEventHandler(MessageForm_MouseDoubleClick);
            this.MouseDown += new MouseEventHandler(MessageForm_MouseDown);
            
        }

        void MessageForm_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Up");
        }

        void MessageForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(string.Format("Window Moved to ({0},{1})", this.Left, this.Top));
        }

        void MessageForm_Move(object sender, EventArgs e)
        {
            
        }

        public void SetAlert(string messageHtml)
        {
            string contents = File.ReadAllText(Properties.Settings.Default.ContentPath + @"\AlertTemplate.html");

            HTMLEditor.DocumentText = contents.Replace("{0}", messageHtml);
        
            
        }
        public void SetMessage(string messageHtml)
        {
            HTMLEditor.DocumentText = "<html><body topmargin='2' leftmargin='2' rightmargin='0'><font face='calibri' size='2'>" + messageHtml + "</font></body></html>";
        }
    }
}
