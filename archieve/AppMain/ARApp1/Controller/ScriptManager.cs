using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Drawing;
using System.Windows.Forms;

namespace ARApp1
{
    public class ScriptManager
    {
        
        public string SceneLink { get; set; }

        private System.Windows.Forms.Timer syncTimer;
        private int currentElementIndex = 0;
        private int lastInterval=0;

        public ScriptManager()
        { 
            
        }

        public void PlayScript()
        {
            
            syncTimer = new System.Windows.Forms.Timer();
            lastInterval = (Global.ScriptElements.ToArray()[0] as ScriptElement).TimeLine;
            syncTimer.Interval = lastInterval * 1000;
            syncTimer.Start();
            syncTimer.Tick +=new EventHandler(syncTimer_Tick); //+= new ElapsedEventHandler(syncTimer_Elapsed);
        }

        void syncTimer_Tick(object sender, EventArgs e)
        {
            // Do current action
            //PerformNextAct();
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

        public void PauseScript()
        { }

        public void StopScript()
        {
            syncTimer.Dispose();
        }

        void syncTimer_Elapsed(object sender, ElapsedEventArgs e)
        {

        }
    }



}
