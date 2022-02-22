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

        static int id = 0;

        public int Id;
        public PersonRepository()
        {
            Id = ++id;

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

        public void UpdatePerson(Person p)
        {
            var updated = _people.First(c => c.Id == p.Id);
            updated.Name = p.Name;
            updated.Surname = p.Surname;
        }

        public void DeletePerson(int id)
        {
            //var silinecekPerson0 = _people.First(c => c.Id == id);
            //var silinecekPerson1 = _people.FirstOrDefault(c => c.Id == id);
            //var silinecekPerson3 = _people.SingleOrDefault(c => c.Id == id);

            var silinecekPerson = _people.Single(c => c.Id == id);

            _people.Remove(silinecekPerson);
        }

       
    }
}
