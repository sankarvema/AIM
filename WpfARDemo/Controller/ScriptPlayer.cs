using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Controller
{
    public static class ScriptPlayer
    {



        static void LoadScript(string scriptPath)
        {
            XDocument anotherDoc = XDocument.Load(scriptPath);
            string xmlData = anotherDoc.ToString();

            var data = from item in anotherDoc.Descendants("Act")
                       select new ScriptElement
                       {
                           TimeLine = int.Parse(item.Attribute("Timeline").Value),
                           Action = (ActionSet)Enum.Parse(typeof(ActionSet), item.Attribute("Action").Value),
                           Command = (CommandSet)Enum.Parse(typeof(CommandSet), item.Attribute("Command").Value),
                           Position = new System.Drawing.Point(int.Parse(item.Attribute("Position").Value.Split(new char[] { ',' })[0]), int.Parse(item.Attribute("Position").Value.Split(new char[] { ',' })[1])),
                           Dimensions = new System.Drawing.Size(int.Parse(item.Attribute("Dimensions").Value.Split(new char[] { ',' })[0]), int.Parse(item.Attribute("Dimensions").Value.Split(new char[] { ',' })[1])),
                           Param1 = item.Attribute("Param1").Value,
                           Param2 = item.Attribute("Param2").Value,
                           Reference = String.IsNullOrEmpty(item.Attribute("Ref").Value) ? -1 : int.Parse(item.Attribute("Ref").Value),
                           Message = item.Element("Message").Value,
                           ControlIndex = int.Parse(item.Attribute("index").Value)
                       };

            //Global.ScriptElements = data.ToList<ScriptElement>();
        }

        public void PerformNextAct()
        {
            ScriptElement element = (ScriptElement)Global.ScriptElements.ToArray()[currentElementIndex];
            ScriptPlayer.Play(ref element);
            Global.ScriptElements.ToArray()[currentElementIndex] = element;

            // Set trigger for next action
            if (currentElementIndex < Global.ScriptElements.Count - 1)
            {
                currentElementIndex++;
                ScriptElement nextElement = (ScriptElement)Global.ScriptElements.ToArray()[currentElementIndex];
                int nextInterval = ((ScriptElement)Global.ScriptElements.ToArray()[currentElementIndex]).TimeLine;
                //if (nextInterval == lastInterval)
                //    //syncTimer.Interval = 1;
                //else
                //    //syncTimer.Interval = (nextInterval - lastInterval) * 1000;
                lastInterval = nextInterval;
            }
            //else
            //    syncTimer.Stop(); // No more actions
        }
    }
}
