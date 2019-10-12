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

namespace _02_BindingClass
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Person> people;
        public MainWindow()
        {
            InitializeComponent();
            people = new ObservableCollection<Person>()
            {
                new Person
                {
                    Name = "Vasja",
                    Surname = "Pupkin",
                    ImagePath = "p1.jpg",
                    Address = new Address
                    {
                        City = "Rivne",
                        Street = "Soborna"
                    }
                },
                 new Person
                {
                    Name = "Olga",
                    Surname = "Pupkina",
                    ImagePath = "p2.jpg",
                    Address = new Address
                    {
                        City = "Kiev",
                        Street = "Grushevskogo"
                    }
                }
            };

            cmb.ItemsSource = people;

            //foreach (var item in people)
            //{
            //}

            list.ItemsSource = people;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          //  stack.DataContext = people.First();
        }

        private void Cmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person p = (sender as ComboBox).SelectedValue as Person;
            stack.DataContext = p;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            people.Add(new Person { Name = "TestName", Surname = "TestSurname" });
        }

        private void List2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var stackSelected = ((sender as ComboBox).SelectedItem as StackPanel);
            //foreach (var item in stackSelected.Children)
            //{
            //    if(item is TextBlock)
            //    {
            //        selected.Text = (item as TextBlock).Text;
            //    }
            //}

            selected.Text = (stackSelected.Children[1] as TextBlock).Text;
        }
    }
}
