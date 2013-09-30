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
using System.Windows.Shapes;

namespace WpfARDemo
{
    /// <summary>
    /// Interaction logic for VideoWin.xaml
    /// </summary>
    public partial class VideoWin : Window
    {
        public string VideoLink { get; set; }

        public VideoWin()
        {
            InitializeComponent();
        }

        private void VideoWinLoaded(object sender, RoutedEventArgs e)
        {

            //Do();
        }

        public void Do()
        {
            videoPlayer.LoadedBehavior = MediaState.Manual;
            videoPlayer.Source = new Uri(VideoLink);
            videoPlayer.Play();
        }
    }
}
