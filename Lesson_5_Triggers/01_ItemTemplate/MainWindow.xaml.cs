using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _01_ItemTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();

            Category categoryElectr = new Category
            {
                Name = "Елоктроніка",
                Color = "Blue"
            };
            Category categoryClother = new Category
            {
                Name = "Одяг",
                Color = "Red"
            };
            products = new ObservableCollection<Product>
            {
                new Product
                {
                    Name = "Телефон мобільний",
                    Price = 5000,
                    Category = categoryElectr
                },
                 new Product
                {
                    Name = "Телевізор",
                    Price = 15000,
                    Category = categoryElectr
                },
                  new Product
                {
                    Name = "Сукня жіноча",
                    Price = 800,
                    Category = categoryClother
                }
            };

            list.ItemsSource = products.Select( x => new
            {
                x.Name,
                x.Price,
                CategoryName = x.Category.Name,
                x.Category.Color
            });
        }
    }


    public class Product
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public int Price { get; set; }
    }

    public class Category
    {
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
