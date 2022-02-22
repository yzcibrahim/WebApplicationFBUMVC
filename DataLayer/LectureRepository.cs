using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class LectureRepository
    {
        private static List<Lecture> _lectures;

        public LectureRepository(PersonRepository pr)
        {
            if(_lectures == null)
            Init();
        }
        public void Init()
        {
            _lectures = new List<Lecture>();
            _lectures.Add(new Lecture("Software I (.Net)", 38));
           // _lectures.Add(new Lecture() { Name="Software I (.Net)", Credit=36 });
        }

        public List<Lecture> GetLectures()
        {
            return _lectures;
        }

        public void AddLecture(Lecture lecture)
        {
            _lectures.Add(lecture);
        }

        public void DeleteLecture(int id)
        {
            // _lectures.Remove(_lectures.First(c => c.Id == id));

            Lecture silinecek = new Lecture();

            foreach(var lect in _lectures)
            {
                if (lect.Id == id)
                {
                    silinecek = lect;
                    break;
                }
            }
            _lectures.Remove(silinecek);
        }
        

    }
}
