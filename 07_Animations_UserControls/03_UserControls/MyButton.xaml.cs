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

namespace _03_UserControls
{
    /// <summary>
    /// Interaction logic for MyButton.xaml
    /// </summary>
    public partial class MyButton : UserControl
    {
        public string MyText
        {
            get { return (string)GetValue(MyTextProperty); }
            set { SetValue(MyTextProperty, value); }
        }

        public static readonly DependencyProperty MyTextProperty = DependencyProperty.Register("MyText", typeof(string), typeof(MyButton), new PropertyMetadata("PRESS ME"));


        public Brush MyColor
        {
            get { return (Brush)GetValue(MyColorProperty); }
            set { SetValue(MyColorProperty, value); }
        }

        public static readonly DependencyProperty MyColorProperty = DependencyProperty.Register("MyColor", typeof(Brush), typeof(MyButton), new PropertyMetadata(Brushes.Red));

        public MyButton()
        {
            InitializeComponent();
        }
    }
}
