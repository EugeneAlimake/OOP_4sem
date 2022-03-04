using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    [Serializable]
    public class Teacher
    {
        [Required]
      
        
        public int classes;
        public string cafedra;
        public string number; 
        [Required(ErrorMessage = "Введите ФИО")]
        public string FIO { get; set; }
    }
}
