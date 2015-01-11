using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ARApp1
{
    public static class ScriptPlayer
    {

        static TextScroll[] message = new TextScroll[5];
        static VideoControl[] video = new VideoControl[5];
        static MessageControl[] msg = new MessageControl[5];
        static MessageControl[] alert = new MessageControl[5];
        static SearchControl[] search = new SearchControl[5];
        static ImageControl[] image = new ImageControl[5];

        static ScriptPlayer()
        { 
            for(int i=0;i<5;i++)
            {
                message[i] = new TextScroll();
                video[i] = new VideoControl();
                msg[i] = new MessageControl();
                alert[i] = new MessageControl();
                search[i] = new SearchControl();
                image[i] = new ImageControl();
            }
        }

        public static void Play(ref ScriptElement element)
        {
            //ScriptElement element = ScriptElements
            //message.MessageText = string.Format("<<{0}>> {1} ({2},{3})\r\n", element.TimeLine, element.Action, element.Param1, element.Param2);
            //message.Show();

            //Form frmHandler = null;
            UserControl control = null;
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

                case CommandSet.Search:
                    //SearchForm search = new SearchForm();
                    //SearchControl search = new SearchControl();
                    search[element.ControlIndex].SearchKey = element.Param1;
                    search[element.ControlIndex].Result = element.Param2;
                    search[element.ControlIndex].Do();

                    //search.Top = element.Position.X;
                    //search.Left = element.Position.Y;
                    //search.Size = element.Dimensions;
                    //Global.MainForm.Controls.Add(search);
                    //search.Show();
                    //frmHandler = search;
                    control = search[element.ControlIndex];
                    break;

                case CommandSet.Image:
                    //ImageControl image = new ImageControl();

                    image[element.ControlIndex].Pic.Top = 0;
                    image[element.ControlIndex].Pic.Left = 0;
                    image[element.ControlIndex].Pic.Image = Image.FromFile(element.Param1);
                    image[element.ControlIndex].Pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    image[element.ControlIndex].Pic.Height = element.Dimensions.Height;
                    image[element.ControlIndex].Pic.Width = element.Dimensions.Width;

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
                    control.Size = element.Dimensions;
                    Global.MainForm.Controls.Add(control);
                    //frmHandler.Show();
                    control.BringToFront();
                    element.Handler = control;
                    control.Show();

                    (control as ControlInterface).Do();
                    break;

                case ActionSet.End:
                    //(Global.ScriptElements.ToArray()[element.Reference - 1] as ScriptElement).Handler.Dispose();
                    control.Hide();
                    break;
            }

        }
    }

}
