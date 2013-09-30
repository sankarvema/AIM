using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfARDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindowLoaded(object sender, RoutedEventArgs e)
        {
            //mediaElement1.Stop();
            //InitAction();
            MessageWin msg = new MessageWin();
            msg.Show();
        }

        private void InitAction()
        {
            this.Top = 10;
            this.Left = 10;
            mediaElement1.LoadedBehavior = MediaState.Manual;

            mediaElement1.Play();
        }

        //ScriptPlayer player = null;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            InitAction();
            ScriptPlayer.LoadScript(Properties.Settings.Default.ContentPath + @"\" + Properties.Settings.Default.ScriptFile);
            ScriptPlayer.PerformNextAct();
            
        }

        private static void ShowVideo()
        {
            VideoWin vid = new VideoWin();
            vid.VideoLink = Properties.Settings.Default.ContentPath + @"\engineDemo.avi";
            vid.Show();
            vid.Do();
        }

        private static void ShowImage()
        {
            ImageWin img = new ImageWin();
            img.ImagePath = Properties.Settings.Default.ContentPath + @"\Rod-Fitting.png";

            img.Show();
            img.Do();
        }

        private void ShowAlert()
        {
            AlertWin alert = new AlertWin();
            alert.BorderThickness = new Thickness(0);
            alert.Visibility = System.Windows.Visibility.Collapsed;
            alert.Owner = this;
            alert.Top = 80;
            alert.Left = 120;
            alert.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ScriptPlayer.PerformNextAct();
        }


    }
}
