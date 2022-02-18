using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Person
    {
        static int total = 0;
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Id = total;
            total++;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
