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

namespace TabControl_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                Expander ex = new Expander() { Header = i.ToString() };
                ex.Content = "Some msg";
                msgStack.Children.Add(ex);

            }
        }

        private void Lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // (e.OriginalSource)
            Selected_User.Text = ((TextBox)((DockPanel)lst.SelectedItem).Children[1]).Text;


        }
    }
}
