using System;
using System.Collections.Generic;
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

namespace _02_ViewBox
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

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse ellipse = new Ellipse
            {
                Width = 100,
                Height = 70,
                Fill = Brushes.Red,
                Stroke = Brushes.Black,
                StrokeThickness = 5
            };
            Random r = new Random();
            Canvas.SetTop(ellipse, r.Next(10, 200));
            canvas.Children.Add(ellipse);
        }

        private void Ellipse_MouseEnter(object sender, MouseEventArgs e)
        {
            ellipse_1.Fill = Brushes.BlanchedAlmond;
        }

        private void Ellipse_1_MouseLeave(object sender, MouseEventArgs e)
        {
            ellipse_1.Fill = Brushes.Violet;
        }
    }
}
