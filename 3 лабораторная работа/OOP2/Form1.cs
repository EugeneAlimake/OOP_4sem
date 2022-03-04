using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        public static string masseg;
        public int count = 0;
        public int count_seat = 0;
        public all all;
        public Alls alls = new Alls();
        public Alls semSearchResult = new Alls();
        public Alls cursSearchResult = new Alls();
        public Alls lectorSearchResults = new Alls();
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
                if (SubjectName.Text == "") { throw new Exception("Сначала запишите название предмета"); }
                if (teachername.Text == "") { throw new Exception("Заполните поле ФИО"); }
               
                all All = new all();
                Subject subject = new Subject();
                subject.subjectname = SubjectName.Text;
                string pup=courses.Text;
                subject.subjectcurses = Convert.ToInt32(pup);
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
                else
                {    
                    throw new Exception("Отметьте семестр ");
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
                var results = new List<ValidationResult>();
                var context = new ValidationContext(subject);
               
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
                    textBox3.Text += i.FIO + "\n ";
                }
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Find f2 = new Find();
            f2.Show(this);
            masseg = "Поиск по Лектору";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Semestr f3 = new Semestr();
            f3.Show(this);
            masseg = "Поиск по семетсту";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Curs f4 = new Curs();
            f4.Show(this);
            masseg = "Поиск по курсу";
        }

        private void teachername_TextChanged(object sender, EventArgs e)
        {

        }

        private void поКолвуЛекцийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (alls.alls.Count == 0)
                {
                    throw new Exception("Нет объектов для сортировки");
                }
                var idSort = from u in alls.alls
                             orderby u.subject.subjectnumbertimes
                             select u;
                StringBuilder str = new StringBuilder();
                foreach (all i in idSort)
                {
                    str.Append(Convert.ToString(i.subject.subjectnumbertimes+" "+i.subject.subjectname)+"\n");
                }
                MessageBox.Show(str.ToString());
                masseg = "Сортировка по количеству лекций";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void поВидуКонтроляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (alls.alls.Count == 0)
                {
                    throw new Exception("Нет объектов для сортировки");
                }
                var idSort = from u in alls.alls
                             orderby u.subject.control
                             select u;
                StringBuilder str = new StringBuilder();
                foreach (all i in idSort)
                {
                    str.Append(Convert.ToString(i.subject.control+" "+ i.subject.subjectname) + "\n");
                }

                MessageBox.Show(str.ToString());
                 masseg = "Сортировка по виду контроля";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

}

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Alls));
            if (semSearchResult.alls.Count > 0)
            {
                using (FileStream stream = new FileStream("TypeSearch.xml", FileMode.OpenOrCreate))
                {
                    serializer.Serialize(stream, semSearchResult);
                }
            }
            if (cursSearchResult.alls.Count > 0)
            {
                using (FileStream stream = new FileStream("SeatsSearch.xml", FileMode.OpenOrCreate))
                {
                    serializer.Serialize(stream, cursSearchResult);
                }
            }
            if (lectorSearchResults.alls.Count > 0)
            {
                using (FileStream stream = new FileStream("ModelSearch.xml", FileMode.OpenOrCreate))
                {
                    serializer.Serialize(stream, lectorSearchResults);
                }
            }
            masseg = "Сохранение";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Николаева Евгения \n Версия: 1.0");
        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void скрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Hide();
            button1.Show();
        }

        private void menuStrip1_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void menuStrip1_Validated(object sender, EventArgs e)
        { 
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuStrip1.Show();
            button1.Hide();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
           toolStripStatusLabel1.Text = "Текущее время - " + DateTime.Now.ToString() + "| Кол-во объектов - " + alls.alls.Count + "| " + masseg;
        }
    }
}
