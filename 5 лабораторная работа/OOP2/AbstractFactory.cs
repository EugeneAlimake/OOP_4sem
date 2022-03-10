using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public abstract class AbstractFactory
    {
        public abstract Teacher CreateTeacher();
    }

    public class ISATFactory : AbstractFactory
    {
        public override Teacher CreateTeacher()
        {
            return new ISATTeacher();
        }
    }
    public class CSAWFactory : AbstractFactory
    {
        public override Teacher CreateTeacher()
        {
            return new CSAWTeacher();
        }
    }
    public class SEFactory : AbstractFactory
    {
        public override Teacher CreateTeacher()
        {
            return new SETeacher();
        }
    }
    public class PhyFactory : AbstractFactory
    {
        public override Teacher CreateTeacher()
        {
            return new PhyTeacher();
        }
    }
    public class EGFactory : AbstractFactory
    {
        public override Teacher CreateTeacher()
        {
            return new EGTeacher();
        }
    }
    public class HMFactory : AbstractFactory
    {
        public override Teacher CreateTeacher()
        {
            return new HMTeacher();
        }
    }
    [Serializable]
    public class ISATTeacher : Teacher
    {
        public ISATTeacher()
        {
            cafedra = "Информационных систем и технологий";
        }
    }
    [Serializable]
    public class CSAWTeacher : Teacher
    {
        public CSAWTeacher()
        {
            cafedra = "Информатики и веб-дизайна";
        }
    }
    [Serializable]
    public class SETeacher : Teacher
    {
        public SETeacher()
        {
            cafedra = "Программной инженерии";
        }
    }
    [Serializable]
    public class PhyTeacher : Teacher
    {
        public PhyTeacher()
        {
            cafedra = "Физики";
        }
    }
    [Serializable]
    public class EGTeacher : Teacher
    {
        public EGTeacher()
        {
            cafedra = "Инженерной графики";
        }
    }
    [Serializable]
    public class HMTeacher : Teacher
    {
        public HMTeacher()
        {
            cafedra = "Высшей математики  ";
        }
    }
}
