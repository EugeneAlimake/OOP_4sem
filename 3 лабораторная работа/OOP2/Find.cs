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
    public partial class Find : Form
    {
        public Alls result = new Alls();
        public Find()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            discipline f1 = this.Owner as discipline;
            f1.lectorSearchResults = result;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
            List<Teacher> result = new List<Teacher>();
            discipline f1 = this.Owner as discipline;
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"[А-Я]у[а-я]+"))  
            {
                foreach (Teacher teacher in f1.teachers)
                {
                    if (teacher.FIO.Contains(textBox1.Text))
                    {
                        result.Add(teacher);
                        textBox2.Text += teacher.FIO+ "\r\n";
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
