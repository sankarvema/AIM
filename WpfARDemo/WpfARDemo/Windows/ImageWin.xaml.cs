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
using System.IO;

namespace WpfARDemo
{
    /// <summary>
    /// Interaction logic for ImageWin.xaml
    /// </summary>
    public partial class ImageWin : Window
    {
        public string ImagePath { get; set; }
        public ImageWin()
        {
            InitializeComponent();
        }

        private void ImageWinLoaded(object sender, RoutedEventArgs e)
        {
            //Do();
        }

        public void Do()
        {
            FileStream stream = new FileStream(ImagePath, FileMode.Open, FileAccess.Read);
            Image i = image1;
            BitmapImage src = new BitmapImage();
            src.BeginInit();
            src.StreamSource = stream;
            src.EndInit();
            i.Source = src;
            i.Stretch = Stretch.Uniform;
        }
    }
}
