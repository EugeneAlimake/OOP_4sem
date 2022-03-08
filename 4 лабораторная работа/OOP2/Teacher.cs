using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    [Serializable]
    public class Teacher
    {
        public string FIO;
        public int classes;
        public string cafedra;
        public string number;  
        public Teacher() { }
        public Teacher(string fio, int Classes, string Cafedra, string Number) 
        {
            FIO = fio;
            classes=Classes;
            cafedra = Cafedra;
            number = Number;
        }
    }
 
}
