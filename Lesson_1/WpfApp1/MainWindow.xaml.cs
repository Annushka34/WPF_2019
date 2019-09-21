using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.WindowState = WindowState.Minimized;
            //this.WindowStyle = WindowStyle.None;
            this.ShowInTaskbar = false;
            this.ResizeMode = ResizeMode.NoResize;
            this.WindowStartupLocation = WindowStartupLocation.CenterOwner;            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyTextBox.Text = "PRESSED";
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            MyBtn.Background = new SolidColorBrush(Color.FromArgb(50, 200, 150, 100));
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            var btn = (ToggleButton)sender;
            if ((btn).IsChecked == true)
            {
                btn.Background = new SolidColorBrush(Color.FromArgb(50, 200, 150, 100));
                MyTextBox.Text = "Checked";
            }
            else
            {
                var color = new SolidColorBrush(Color.FromRgb(50, 50, 255));
                btn.Background = color;
                MyTextBox.Text = "unChecked";
            }

            if ((btn).IsThreeState == true)
            {

            }
        }
        static int counter = 0;

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {

            var btn = (RepeatButton)sender;
            counter++;
            MyTextBox.Text = counter.ToString();
        }
    }
}
