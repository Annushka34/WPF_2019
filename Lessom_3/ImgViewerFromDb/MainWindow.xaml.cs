using DAL;
using DAL.Models;
using Microsoft.Win32;
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

namespace ImgViewerFromDb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EfContext _context;
        public MainWindow()
        {
            InitializeComponent();
            _context = new EfContext();
           
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != String.Empty)
            {
                Img img = new Img();
                FileInfo file = new FileInfo(openFileDialog.FileName);
                img.Path = file.Name;
                img.Description = "djfsjf akfjhaskjfh";
                _context.imgs.Add(img);
                _context.SaveChanges();


                var imgs = _context.imgs.ToList();
                var imgElem = stack.Children;
                int counter = 0;
                var path = Directory.GetCurrentDirectory();
                foreach (Image item in imgElem)
                {
                    if (counter < imgs.Count)
                    {
                        item.Source = new BitmapImage(new Uri(path+"/img/"+imgs[counter].Path));
                        counter++;
                    }
                }
            }
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var path = Directory.GetCurrentDirectory();
            img1.Source = new BitmapImage(new Uri(path + "/img/" + "1.jpg"));
            img1.Stretch = Stretch.UniformToFill;
        }
    }
}
