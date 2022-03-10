using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace OOP2
{
    [Serializable]
    public class all:IClone
    {
        public List<Teacher> teachers;
        public Subject subject;

        public all()
        {
             teachers= new List<Teacher>();
            subject = new Subject();
        }
        public all(List<Teacher> teachers, Subject subject)
        {
            this.teachers = teachers;
            this.subject = subject;
        }

        public IClone Clone()
        {
            var all = new all();
            all = (all)this.MemberwiseClone();
            return all;
            //return new all(teachers, subject);
        }
    }
}
