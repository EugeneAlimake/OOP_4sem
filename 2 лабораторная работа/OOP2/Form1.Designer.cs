
namespace OOP2
{
    partial class discipline
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.term = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.teachername = new System.Windows.Forms.TextBox();
            this.courses = new System.Windows.Forms.ComboBox();
            this.times = new System.Windows.Forms.NumericUpDown();
            this.labtimes = new System.Windows.Forms.NumericUpDown();
            this.SubjectName = new System.Windows.Forms.TextBox();
            this.semestr1 = new System.Windows.Forms.RadioButton();
            this.semestr2 = new System.Windows.Forms.RadioButton();
            this.test = new System.Windows.Forms.RadioButton();
            this.exems = new System.Windows.Forms.RadioButton();
            this.auditorium = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.times)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labtimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorium)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(13, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(77, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Название";
            this.name.Click += new System.EventHandler(this.label1_Click);
            // 
            // term
            // 
            this.term.AutoSize = true;
            this.term.Location = new System.Drawing.Point(13, 68);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(67, 20);
            this.term.TabIndex = 1;
            this.term.Text = "Семестр";
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Location = new System.Drawing.Point(13, 97);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(41, 20);
            this.course.TabIndex = 2;
            this.course.Text = "Курс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество лекций в семестре";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество лабораторных в семестре";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вид контроля";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Информация о Лекторе:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Кафедра";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "ФИО";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Аудитория";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Дисциплина:";
            // 
            // teachername
            // 
            this.teachername.Location = new System.Drawing.Point(290, 325);
            this.teachername.Name = "teachername";
            this.teachername.Size = new System.Drawing.Size(259, 27);
            this.teachername.TabIndex = 11;
            this.teachername.Validating += new System.ComponentModel.CancelEventHandler(this.teachername_Validating);
            // 
            // courses
            // 
            this.courses.FormattingEnabled = true;
            this.courses.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.courses.Location = new System.Drawing.Point(298, 97);
            this.courses.Name = "courses";
            this.courses.Size = new System.Drawing.Size(151, 28);
            this.courses.TabIndex = 12;
            this.courses.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(298, 128);
            this.times.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.times.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(150, 27);
            this.times.TabIndex = 13;
            this.times.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.times.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labtimes
            // 
            this.labtimes.Location = new System.Drawing.Point(298, 158);
            this.labtimes.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.labtimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.labtimes.Name = "labtimes";
            this.labtimes.Size = new System.Drawing.Size(150, 27);
            this.labtimes.TabIndex = 14;
            this.labtimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SubjectName
            // 
            this.SubjectName.Location = new System.Drawing.Point(298, 31);
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Size = new System.Drawing.Size(259, 27);
            this.SubjectName.TabIndex = 15;
            this.SubjectName.TextChanged += new System.EventHandler(this.SubjectName_TextChanged);
            // 
            // semestr1
            // 
            this.semestr1.AutoSize = true;
            this.semestr1.Location = new System.Drawing.Point(3, 0);
            this.semestr1.Name = "semestr1";
            this.semestr1.Size = new System.Drawing.Size(38, 24);
            this.semestr1.TabIndex = 16;
            this.semestr1.TabStop = true;
            this.semestr1.Text = "1";
            this.semestr1.UseVisualStyleBackColor = true;
            this.semestr1.CheckedChanged += new System.EventHandler(this.semestr1_CheckedChanged);
            // 
            // semestr2
            // 
            this.semestr2.AutoSize = true;
            this.semestr2.Location = new System.Drawing.Point(140, 2);
            this.semestr2.Name = "semestr2";
            this.semestr2.Size = new System.Drawing.Size(38, 24);
            this.semestr2.TabIndex = 17;
            this.semestr2.TabStop = true;
            this.semestr2.Text = "2";
            this.semestr2.UseVisualStyleBackColor = true;
            this.semestr2.CheckedChanged += new System.EventHandler(this.semestr2_CheckedChanged);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(3, 3);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(67, 24);
            this.test.TabIndex = 18;
            this.test.TabStop = true;
            this.test.Text = "зачет";
            this.test.UseVisualStyleBackColor = true;
            this.test.CheckedChanged += new System.EventHandler(this.test_CheckedChanged);
            // 
            // exems
            // 
            this.exems.AutoSize = true;
            this.exems.Location = new System.Drawing.Point(90, 3);
            this.exems.Name = "exems";
            this.exems.Size = new System.Drawing.Size(87, 24);
            this.exems.TabIndex = 19;
            this.exems.TabStop = true;
            this.exems.Text = "экзамен";
            this.exems.UseVisualStyleBackColor = true;
            this.exems.CheckedChanged += new System.EventHandler(this.exems_CheckedChanged);
            // 
            // auditorium
            // 
            this.auditorium.Location = new System.Drawing.Point(290, 362);
            this.auditorium.Maximum = 255;
            this.auditorium.Minimum = 1;
            this.auditorium.Name = "auditorium";
            this.auditorium.Size = new System.Drawing.Size(221, 56);
            this.auditorium.TabIndex = 20;
            this.auditorium.Value = 1;
            this.auditorium.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(536, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Текущее значение";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // department
            // 
            this.department.FormattingEnabled = true;
            this.department.Items.AddRange(new object[] {
            "Информационных систем и технологий",
            "Информатики и веб-дизайна",
            "Программной инженерии",
            "Физики",
            "Инженерной графики",
            "Высшей математики"});
            this.department.Location = new System.Drawing.Point(290, 285);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(383, 28);
            this.department.TabIndex = 22;
            this.department.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Телефон";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(298, 404);
            this.telephone.Mask = "(99) 000-0000";
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(98, 27);
            this.telephone.TabIndex = 25;
            this.telephone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(732, 279);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(221, 148);
            this.textBox3.TabIndex = 26;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // add
            // 
            this.add.Enabled = false;
            this.add.Location = new System.Drawing.Point(536, 402);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(94, 29);
            this.add.TabIndex = 27;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(706, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 29);
            this.button2.TabIndex = 28;
            this.button2.Text = "вывод";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(706, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 29);
            this.button3.TabIndex = 29;
            this.button3.Text = "Добавить все";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.semestr1);
            this.panel1.Controls.Add(this.semestr2);
            this.panel1.Location = new System.Drawing.Point(298, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 27);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.test);
            this.panel2.Controls.Add(this.exems);
            this.panel2.Location = new System.Drawing.Point(301, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 34);
            this.panel2.TabIndex = 31;
            // 
            // discipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 457);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.auditorium);
            this.Controls.Add(this.SubjectName);
            this.Controls.Add(this.labtimes);
            this.Controls.Add(this.times);
            this.Controls.Add(this.courses);
            this.Controls.Add(this.teachername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.course);
            this.Controls.Add(this.term);
            this.Controls.Add(this.name);
            this.Name = "discipline";
            this.Text = "Дисциплина";
            this.Load += new System.EventHandler(this.Дисциплина_Load);
            ((System.ComponentModel.ISupportInitialize)(this.times)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labtimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorium)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label term;
        private System.Windows.Forms.Label course;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox teachername;
        private System.Windows.Forms.ComboBox courses;
        private System.Windows.Forms.NumericUpDown times;
        private System.Windows.Forms.NumericUpDown labtimes;
        private System.Windows.Forms.TextBox SubjectName;
        private System.Windows.Forms.RadioButton semestr1;
        private System.Windows.Forms.RadioButton semestr2;
        private System.Windows.Forms.RadioButton test;
        private System.Windows.Forms.RadioButton exems;
        private System.Windows.Forms.TrackBar auditorium;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox telephone;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

