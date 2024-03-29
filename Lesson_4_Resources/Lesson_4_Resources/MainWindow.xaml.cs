﻿using System;
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

namespace Lesson_4_Resources
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
            //RadialGradientBrush brush = (RadialGradientBrush)this.Resources["myGrad"];
            // brush.GradientStops.Add(new GradientStop(Colors.AliceBlue, 0.3));

            this.Resources["myGrad"] = new RadialGradientBrush(Colors.Blue, Colors.Black);
        }
    }
}
