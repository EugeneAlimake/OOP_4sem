using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    [Serializable]
    public class Subject
    {
        public string subjectname;
        [Required]
        public int subjectsem { get; set; }
        [Required]
        public int subjectcurses { get; set; }
        public int subjectnumbertimes;
        public int labnumbertimes;
        public string control;
    }
}
