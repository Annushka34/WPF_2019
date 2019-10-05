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

namespace _05_DragAndDrop
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

        //private void TextBox_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    Label txt = sender as Label;
        //    var text = txt.Content;
        //    if (text != null)
        //    {
        //        DragDrop.DoDragDrop(txt, text, DragDropEffects.All);
        //    }
        //}

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox txt = sender as TextBox;
            var text = txt.SelectedText;
            if (text != null)
            {
                DragDrop.DoDragDrop(txt, text, DragDropEffects.All);
            }
        }

        //private void TextBox_DragEnter(object sender, DragEventArgs e)
        //{
        //    ((TextBox)sender).Text = (string)e.Data.GetData(DataFormats.Text);
        //}
    }
}
