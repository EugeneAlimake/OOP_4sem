
namespace OOP_1
{
    partial class calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.degree = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.equally = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.remains = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Sylfaen", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(394, 98);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear.Location = new System.Drawing.Point(12, 116);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(94, 68);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plus.Location = new System.Drawing.Point(112, 116);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(94, 68);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minus.Location = new System.Drawing.Point(212, 117);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(94, 68);
            this.minus.TabIndex = 3;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.multiplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplication.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplication.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multiplication.Location = new System.Drawing.Point(312, 117);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(94, 68);
            this.multiplication.TabIndex = 4;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.division.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.division.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.division.Location = new System.Drawing.Point(313, 191);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(94, 68);
            this.division.TabIndex = 5;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // degree
            // 
            this.degree.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.degree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.degree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.degree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.degree.Location = new System.Drawing.Point(313, 266);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(94, 68);
            this.degree.TabIndex = 6;
            this.degree.Text = "^";
            this.degree.UseVisualStyleBackColor = false;
            this.degree.Click += new System.EventHandler(this.degree_Click);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.n1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n1.Location = new System.Drawing.Point(12, 191);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(94, 68);
            this.n1.TabIndex = 7;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.n2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n2.Location = new System.Drawing.Point(112, 191);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(94, 68);
            this.n2.TabIndex = 8;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // equally
            // 
            this.equally.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.equally.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.equally.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equally.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equally.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equally.Location = new System.Drawing.Point(313, 414);
            this.equally.Name = "equally";
            this.equally.Size = new System.Drawing.Size(94, 68);
            this.equally.TabIndex = 17;
            this.equally.Text = "=";
            this.equally.UseVisualStyleBackColor = false;
            this.equally.Click += new System.EventHandler(this.equally_Click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.n0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n0.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n0.Location = new System.Drawing.Point(112, 414);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(94, 68);
            this.n0.TabIndex = 16;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.n7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n7.Location = new System.Drawing.Point(12, 339);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(94, 68);
            this.n7.TabIndex = 13;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.n8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n8.Location = new System.Drawing.Point(112, 339);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(94, 68);
            this.n8.TabIndex = 14;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.n9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n9.Location = new System.Drawing.Point(212, 339);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(94, 68);
            this.n9.TabIndex = 15;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.n6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n6.Location = new System.Drawing.Point(212, 265);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(94, 68);
            this.n6.TabIndex = 12;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.n5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n5.Location = new System.Drawing.Point(112, 265);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(94, 68);
            this.n5.TabIndex = 11;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.n4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n4.Location = new System.Drawing.Point(12, 265);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(94, 68);
            this.n4.TabIndex = 10;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.n3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.n3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.n3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.n3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.n3.Location = new System.Drawing.Point(213, 191);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(94, 68);
            this.n3.TabIndex = 9;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // remains
            // 
            this.remains.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.remains.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.remains.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remains.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remains.Location = new System.Drawing.Point(313, 339);
            this.remains.Name = "remains";
            this.remains.Size = new System.Drawing.Size(94, 68);
            this.remains.TabIndex = 18;
            this.remains.Text = "%";
            this.remains.UseVisualStyleBackColor = false;
            this.remains.Click += new System.EventHandler(this.remains_Click_1);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(419, 494);
            this.Controls.Add(this.remains);
            this.Controls.Add(this.equally);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.degree);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.textBox1);
            this.Name = "calculator";
            this.Text = "Сalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button degree;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button equally;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button remains;
    }
}

