using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BindingClass
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Address Address { get; set; }
        public string ImagePath { get; set; } 

        public override string ToString()
        {
            return $"{Surname} {Name}";
        }
    }


    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
    }
}
