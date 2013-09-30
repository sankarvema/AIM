using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Windows;

namespace WpfARDemo
{
    public static class ScriptPlayer
    {
        static TextWin[] message = new TextWin[5];
        static VideoWin[] video = new VideoWin[5];
        static AlertWin[] msg = new AlertWin[5];
        static AlertWin[] alert = new AlertWin[5];
        //static SearchControl[] search = new SearchControl[5];
        static ImageWin[] image = new ImageWin[5];

        static ScriptPlayer()
        {
            for (int i = 0; i < 5; i++)
            {
                message[i] = new TextWin();
                video[i] = new VideoWin();
                msg[i] = new AlertWin();
                alert[i] = new AlertWin();
                //search[i] = new SearchControl();
                image[i] = new ImageWin();
            }
        }

        public static void Play(ScriptElement element)
        {
            //ScriptElement element = ScriptElements
            //message.MessageText = string.Format("<<{0}>> {1} ({2},{3})\r\n", element.TimeLine, element.Action, element.Param1, element.Param2);
            //message.Show();

            //Form frmHandler = null;
            Window control = null;
            switch (element.Command)
            {
                case CommandSet.Video:
                    //VideoControl video = new VideoControl();
                    video[element.ControlIndex].VideoLink = element.Param1;

                    control = video[element.ControlIndex];
                    break;

                case CommandSet.Message:
                    //MessageControl msg = new MessageControl();

                    switch (element.Action)
                    {
                        case ActionSet.Init:
                        case ActionSet.Refresh:
                            msg[element.ControlIndex].SetMessage(element.Message);
                            break;

                        case ActionSet.Resume:
                            msg[element.ControlIndex].SetMessage(element.Message);
                            break;
                    }

                    control = msg[element.ControlIndex];
                    break;

                case CommandSet.Alert:
                    //MessageControl alert = new MessageControl();
                    alert[element.ControlIndex].SetAlert(element.Message);

                    control = alert[element.ControlIndex];
                    break;

                //case CommandSet.Dummy:
                //    AlertForm dummy = new AlertForm();
                //    //alert.SetMessage(element.Param1);

                //    frmHandler = dummy;
                //    break;

                //case CommandSet.Search:
                //    //SearchForm search = new SearchForm();
                //    //SearchControl search = new SearchControl();
                //    search[element.ControlIndex].SearchKey = element.Param1;
                //    search[element.ControlIndex].Result = element.Param2;
                //    search[element.ControlIndex].Do();

                //    //search.Top = element.Position.X;
                //    //search.Left = element.Position.Y;
                //    //search.Size = element.Dimensions;
                //    //Global.MainForm.Controls.Add(search);
                //    //search.Show();
                //    //frmHandler = search;
                //    control = search[element.ControlIndex];
                //    break;

                case CommandSet.Image:
                    //ImageControl image = new ImageControl();

                    //image[element.ControlIndex].Pic.Top = 0;
                    //image[element.ControlIndex].Pic.Left = 0;
                    //image[element.ControlIndex].Pic.Image = Image.FromFile(element.Param1);
                    //image[element.ControlIndex].Pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    //image[element.ControlIndex].Pic.Height = element.Dimensions.Height;
                    //image[element.ControlIndex].Pic.Width = element.Dimensions.Width;

                    control = image[element.ControlIndex];
                    break;
                default:
                    MessageBox.Show("Unknown command " + element.Command.ToString());
                    break;
            }

            switch (element.Action)
            {
                case ActionSet.Init:
                    control.Top = element.Position.X;
                    control.Left = element.Position.Y;
                    //control.Size = element.Dimensions;
                    //Global.MainForm.Controls.Add(control);
                    //frmHandler.Show();
                    //control.BringToFront();
                    //element.Handler = control;
                    control.Show();

                    //(control as ControlInterface).Do();
                    break;

                case ActionSet.End:
                    //(Global.ScriptElements.ToArray()[element.Reference - 1] as ScriptElement).Handler.Dispose();
                    control.Hide();
                    break;
            }

        }


        public static void LoadScript(string scriptPath)
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

            Global.ScriptElements = data.ToList<ScriptElement>();
        }

        static int currentElementIndex = 0;
        public static void PerformNextAct()
        {
            ScriptElement element = (ScriptElement)Global.ScriptElements.ToArray()[currentElementIndex];
            ScriptPlayer.Play(element);
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
                //lastInterval = nextInterval;
            }
            //else
            //    syncTimer.Stop(); // No more actions
        }
    }
}
