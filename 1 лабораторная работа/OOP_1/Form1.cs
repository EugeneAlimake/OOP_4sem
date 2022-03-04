using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_1
{
    public partial class calculator : Form
    {
        int first, second, star, b, divis, remain, degre;
        public calculator()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                second = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="")
            {
                first = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void n2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void n3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void n4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void n5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void n6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void n7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void n8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void n9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                star = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void remains_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                remain= Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void degree_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                degre = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                divis = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void equally_Click(object sender, EventArgs e)
        {
            if(first!=0)
            {
                b = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(first + b);
                first = 0;
                b = 0;
            }
            if (second!= 0)
            {
                b = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(second - b);
                second = 0;
                b = 0;
            }
            if(star!=0)
            {
                b = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(star * b);
                star = 0;
                b = 0;
            }
            if (divis != 0)
            {
                b = Convert.ToInt32(textBox1.Text);
                if (b != 0)
                    textBox1.Text = Convert.ToString(divis / b);
                else
                    textBox1.Text = "ERROR";
                divis = 0;
                b = 0;
            }
            if (degre != 0)
            {
                int res = degre;
                b = Convert.ToInt32(textBox1.Text);
                for(int i=1; i<b;i++)
                {
                    res *= degre;
                }
                degre = res;
                textBox1.Text = Convert.ToString(degre);
               
                degre = 0;
                b = 0;
            }
            if (remain!= 0)
            {
                b = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(remain%b);
                star = 0;
                b = 0;
            }

        }

        private void n0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            first = 0;
            b = 0;
            star = 0;
            second = 0;
            divis = 0;
            degre = 0;
        }
    }
}
