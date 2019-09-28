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

namespace _04_CreateElementsInSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> people;
        public MainWindow()
        {
            InitializeComponent();
            people = new List<Person>
            {
                new Person{Name = "Vasja", Surname="Pupkin", Salary=10000},
                new Person{Name = "Ivan", Surname="Pupkin", Salary=10000},
                new Person{Name = "Stepan", Surname="Pupkin", Salary=2000},
                new Person{Name = "Semen", Surname="Pupkin", Salary=7000},
                new Person{Name = "Larisa", Surname="Zukova", Salary=10000}
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int counter = 1;
            foreach (var item in people)
            {
                MyGrid.RowDefinitions.Add(new RowDefinition());
                UniformGrid panel = new UniformGrid();
                panel.Columns = 3;
                
                TextBox text = new TextBox { Text = item.Name };
                TextBox text1 = new TextBox { Text = item.Surname };
                TextBox text2 = new TextBox { Text = item.Salary.ToString() };
                panel.Children.Add(text);
                panel.Children.Add(text1);
                panel.Children.Add(text2);

                MyGrid.Children.Add(panel);
                Grid.SetRow(panel, counter);
                counter++;
            }
        }
    }
}
