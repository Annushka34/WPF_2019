using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _06_Media
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string path;
        public MainWindow()
        {
            InitializeComponent();
            path = Directory.GetCurrentDirectory();

        }

        private void MediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            media.Source = new Uri(path+ @"/media/Ария_-_Засыпай.mp3");
            media.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            media.Stop();
            media.Source = new Uri(path + @"/media/video.mp4");
            media.Play();
        }
    }
}
