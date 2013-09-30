using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ARApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadScript();
            
            Application.Run(new MainForm());
        }

        static void LoadScript()
        {
            XDocument anotherDoc = XDocument.Load(Properties.Settings.Default.ContentPath + Properties.Settings.Default.ScriptFile);
            string xmlData = anotherDoc.ToString();

            var data = from item in anotherDoc.Descendants("Act")
                       select new ScriptElement
                       {
                           TimeLine = int.Parse(item.Attribute("Timeline").Value),
                           Action = (ActionSet)Enum.Parse(typeof(ActionSet), item.Attribute("Action").Value),
                           Command = (CommandSet)Enum.Parse(typeof(CommandSet), item.Attribute("Command").Value),
                           Position = new System.Drawing.Point(int.Parse(item.Attribute("Position").Value.Split(new char[] {','})[0]), int.Parse(item.Attribute("Position").Value.Split(new char[] {','})[1])),
                           Dimensions = new System.Drawing.Size(int.Parse(item.Attribute("Dimensions").Value.Split(new char[] { ',' })[0]), int.Parse(item.Attribute("Dimensions").Value.Split(new char[] { ',' })[1])),
                           Param1 = item.Attribute("Param1").Value,
                           Param2 = item.Attribute("Param2").Value,
                           Reference = String.IsNullOrEmpty(item.Attribute("Ref").Value)? -1: int.Parse(item.Attribute("Ref").Value),
                           Message = item.Element("Message").Value,
                           ControlIndex = int.Parse(item.Attribute("index").Value)
                       };

            Global.ScriptElements = data.ToList<ScriptElement>();
        }
    }
}
