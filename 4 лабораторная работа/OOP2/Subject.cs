using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    [Serializable]
    public class Subject:IClone
    {
        public string subjectname;
        public int subjectsem;
        public string subjectcurses;
        public int subjectnumbertimes;
        public int labnumbertimes;
        public Teacher teacher;
        public string control;
        public Subject()
            {

            teacher = new Teacher();
        }
        public Subject(string name, int sem, string course, int numLect, int numLabs, string ctrl, Teacher lect)
        {
            subjectname = name;
            subjectsem = sem;
            subjectcurses = course;
            subjectnumbertimes = numLect;
            labnumbertimes = numLabs;
            control = ctrl;
            teacher = lect;
        }

        public IClone Clone()
        {
            var subject = new Subject();
            subject = (Subject)this.MemberwiseClone();
            return subject;
        }
    }
}
