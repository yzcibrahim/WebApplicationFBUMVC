using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Lecture
    {
        public Lecture(string name, int credit)
        {
            // Id = total++;
            Id = ++total;
            Name = name;
            Credit = credit;

        }

        public Lecture()
        {
            Id = ++total;
        }
        public static int total = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }

    }
}
