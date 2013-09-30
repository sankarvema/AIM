using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ARApp1
{
    public partial class MessageControl : UserControl, ControlInterface
    {
        public MessageControl()
        {
            InitializeComponent();
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

        public void Do()
        {
            //throw new NotImplementedException();
        }
    }
}
