using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PersonRepository
    {
        private static List<Person> _people;

        public PersonRepository()
        {
            if(_people==null)
            Init();
        }
        public void Init()
        {
            _people = new List<Person>();
            _people.Add(new Person("ibrahim", "yazıcı"));
        }

        public List<Person> GetPeople()
        {
            return _people;
        }

        public void AddPerson(Person p)
        {
            _people.Add(p);
        }
        

    }
}
