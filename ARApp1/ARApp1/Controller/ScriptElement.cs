using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace ARApp1
{
    public class ScriptElement
    {
        public int TimeLine { get; set; }
        public ActionSet Action { get; set; }
        public CommandSet Command { get; set; }
        public Point Position { get; set; }
        public Size Dimensions { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
        public UserControl Handler { get; set; }
        //public ScriptElement Ref { get { return (ScriptElement) scrip
        public int Reference { get; set; }
        public string Message { get; set; }
        public int ControlIndex { get; set; }
    }

    public enum ActionSet { Init, End, Refresh, Resume }
    public enum CommandSet { Video, Image, Alert, Message, Graphic, Search, Dummy, Form }
}
