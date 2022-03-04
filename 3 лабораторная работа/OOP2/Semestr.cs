using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    public partial class Semestr : Form
    {
        public Semestr()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Alls result = new Alls();
            discipline f1 = this.Owner as discipline;
            if (radioButton1.Checked)
            {
                foreach (all i in f1.alls.alls)
                {
                    if (i.subject.subjectsem == 1)
                    {
                        result.alls.Add(i);
                        textBox1.Text += i.subject.subjectname + "\r\n";
                    }
                }
               
            }
            if (radioButton2.Checked)
            {
                foreach (all i in f1.alls.alls)
                {
                    if (i.subject.subjectsem == 2)
                    {
                        result.alls.Add(i);
                        textBox1.Text += i.subject.subjectname + "\r\n";
                    }
                }
     
                 
            }
            f1.semSearchResult.alls = result.alls;
        }
       
    }
    
}

