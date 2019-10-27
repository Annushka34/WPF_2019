using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace Lesson_6_Shapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User user;
        public MainWindow()
        {
            InitializeComponent();
            user = new User
            {
                Name = "Vasiliy",
                Email = "vas@gmail.com",
                Age = 25
            };
            userStack.DataContext = user;
        }
    }

    public class User : IDataErrorInfo
    {
        public string this[string columnName]
        {
            get
            {
            string err = "";
                switch (columnName)
                {
                    case "Name":
                        {
                            if(Name.Any(x => !Char.IsLetter(x)))
                                myError =  "No correct name";
                            break;
                        }
                }
                return err;
            }
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string myError { get; set; }

        public string Error
        {
            get { return null; }
        }
    }
}
