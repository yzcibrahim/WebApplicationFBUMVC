using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFBUMVC.Models
{
    public class Person
    {
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string FullName
        {
            get {
                return $"{Name} {Surname}";
            }

        }
    }
}
