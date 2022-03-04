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
    public partial class Curs : Form
    {
        public Curs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            Alls result = new Alls();
            discipline f1 = this.Owner as discipline;
            int curses = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            foreach (all i in f1.alls.alls)
            {
                if (i.subject.subjectcurses == curses)
                {
                    result.alls.Add(i);
                    textBox2.Text += i.subject.subjectname+"\r\n";
                }
            }
            f1.cursSearchResult = result;
        }
    }
}
