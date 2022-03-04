using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OOP2
{
    public partial class discipline : Form
    {
        public int count = 0;
        public int count_seat = 0;
        public all all;
        public Alls alls = new Alls();
        public discipline()
        {
            InitializeComponent();
            all = new all();
        }
        public List<Teacher> teachers = new List<Teacher>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Дисциплина_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label9.Text = string.Format($"Текущее значение: {auditorium.Value}");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void SubjectName_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher temp = new Teacher();
                temp.FIO = teachername.Text;
                temp.classes = auditorium.Value;
                temp.cafedra = department.Text;
                temp.number = telephone.Text;
                foreach (Teacher i in teachers)
                {
                    if (temp.FIO == i.FIO)
                    {
                        throw new Exception("Попытка повторного добавления");
                    }
                }
                teachers.Add(temp);
                textBox3.Text += temp.FIO + "\r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void teachername_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(teachername.Text, @"(([А-Я][а-я]+(\s?))+$)|([А-Я][а-я]+(-?)([А-Я]?)([а-я]+)$)"))
            {
                teachername.Tag = false;
            }
            else { teachername.Tag = true; }
            add.Enabled = (bool)teachername.Tag;
        }

        private void semestr1_CheckedChanged(object sender, EventArgs e)
        {
            if (semestr1.Checked)
            {
                semestr2.Checked = false;
            }
        }

        private void semestr2_CheckedChanged(object sender, EventArgs e)
        {
            if (semestr2.Checked)
            {
                semestr1.Checked = false;
            }
        }

        private void test_CheckedChanged(object sender, EventArgs e)
        {
            if (test.Checked)
            {
                exems.Checked = false;
            }
        }

        private void exems_CheckedChanged(object sender, EventArgs e)
        {
            if (exems.Checked)
            {
                test.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (SubjectName.Text == "") { throw new Exception("Сначала запишите работника"); }
                if (teachername.Text == "") { throw new Exception("Заполните поле идентификатора"); }
                all All = new all();
                Subject subject = new Subject();
                subject.subjectname = SubjectName.Text;
                subject.subjectcurses = courses.Text;
                subject.subjectnumbertimes = (int)times.Value;
                subject.labnumbertimes = (int)labtimes.Value;
                if (semestr1.Checked)
                {
                    subject.subjectsem = 1;
                }
                else if(semestr2.Checked)
                {
                    subject.subjectsem = 2;
                }
                if (test.Checked)
                {
                    subject.control ="зачет";
                }
                else if (exems.Checked)
                {
                    subject.control = "экзамен";
                }
                All.subject = subject;
                All.teachers = teachers;
                count = 0;
                
                XmlSerializer serializer = new XmlSerializer(typeof(all));
                using (FileStream stream = new FileStream("all.xml", FileMode.Create))
                {
                    serializer.Serialize(stream, All);
                }
                
                    alls.alls.Add(All);
                teachers.Clear();
                MessageBox.Show("Данные были сохранены в файл");
                textBox3.Clear();
                teachername.Clear();
                auditorium.Value=1;
                department.Text="";
                telephone.Clear();
                SubjectName.Clear();
                times.Value=1;
                labtimes.Value=1;
                semestr1.Checked=false;
                semestr2.Checked=false;
                test.Checked=false;
                exems.Checked = false;
    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlSerializer ser = new XmlSerializer(typeof(all));
            using (FileStream stream = new FileStream("all.xml", FileMode.OpenOrCreate))
            {
                all c = (all)ser.Deserialize(stream);
                foreach (Teacher i in c.teachers)
                {
                    textBox3.Text += i.FIO + " ";
                }
            }
        }
    }
}
