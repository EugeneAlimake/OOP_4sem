using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Validation: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value !=null)
            {
                Subject subject = value as Subject;
                /*int puk = Convert.ToInt32(value);*/
                if (subject.subjectcurses == 0)
                {
                    this.ErrorMessage = "Вы не выбрали семестр";
                }
                else return true;
            }
            return false;
        }
    }
}
