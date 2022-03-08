using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
   public abstract class DisciplineFactory     // AbstractFactory
    {
        public Subject SubjplusTeach { get; private set; }
        public void Subjectconst() => SubjplusTeach = new Subject();
        public abstract void CreateSubject();
        public abstract void CreateTeacher();
    }

    class Meneger
    {
        public Subject AllAll(DisciplineFactory factory)
        {   
            factory.Subjectconst();
            factory.CreateSubject();
            factory.CreateTeacher();
            return factory.SubjplusTeach;
        }
        public static void SubjectandTeacher()
        {
            Meneger meneger= new Meneger();

            DisciplineFactory factory = new OOP();
            Subject econ = meneger.AllAll(factory);
            MessageBox.Show($"Преподаватель:{econ.teacher.FIO}\n"+
                $"Кафедра:{econ.teacher.cafedra}\n" +
                $"Предмет:{econ.subjectname}");
            


        }
    }
    public class OOP : DisciplineFactory //ProductA1
    {
        public override void CreateSubject()
        {
            SubjplusTeach.subjectname="OОП";
            SubjplusTeach.subjectsem = 2;
            SubjplusTeach.subjectcurses = "2";
            SubjplusTeach.subjectnumbertimes = 102;
            SubjplusTeach.labnumbertimes = 36;
            SubjplusTeach.control = "экзамен";

        }

        public override void CreateTeacher()
        {
            SubjplusTeach.teacher =new Teacher("Н.В.Пацей", 105, "Информационных систем и технологий","10521445");
        }

    }
}
