using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace OOP2
{
    [Serializable]
    public class all
    {
        public List<Teacher> teachers;
        public Subject subject;

        public all()
        {
             teachers= new List<Teacher>();
            subject = new Subject();
        }
    }
}
