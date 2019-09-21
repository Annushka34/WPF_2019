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

namespace _03_DockPanel
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var text1 = ((ListBoxItem) myListBox.Items[0]).Content;
            var text2 = ((ListBoxItem)myListBox.Items[0]).Content;
            ((ListBoxItem)myListBox.Items[3]).Content += (Int32.Parse(text1.ToString()) + Int32.Parse(text2.ToString())).ToString();
        }
    }
}
