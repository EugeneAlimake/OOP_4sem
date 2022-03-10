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
    public partial class _4_labs : Form
    {
        public _4_labs()
        {
            InitializeComponent();
        }

        private void _4_labs_Load(object sender, EventArgs e)
        {

        }
        public Singleton font
        {
            get; set;
        }
        private void button2_Click(object sender, EventArgs e)
        {  font = Singleton.GetInstance( this.Font.ToString());
         
 
            MessageBox.Show(font.settings);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meneger.SubjectandTeacher();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
    
}
