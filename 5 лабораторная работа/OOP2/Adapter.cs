using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public interface Target
    {
        string StartTeach();
    }
    public class Adapter : Target
    {
        private readonly Teacher teacher;
        public Adapter(Teacher teacher)
        {
            this.teacher = teacher;
        }
        public string StartTeach()
        {
            return $"{this.teacher.FIO} {this.teacher.Teach()}";
        }
    }
}
