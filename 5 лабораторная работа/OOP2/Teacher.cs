using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    [Serializable]
    public enum TeacheState
    {
        Create,
        Add,
        Save
    }
    public class Teacher
    {
        public string FIO;
        public int classes;
        public string cafedra;
        public string number;  
        
        public Teacher() { }
        public Teacher(string fio, int Classes, string Cafedra, string Number) 
        {
            FIO = fio;
            classes=Classes;
            cafedra = Cafedra;
            number = Number;
        }
        public string Teach()
        {
            return $"Преподает на кафедре {cafedra}";
        }
           
        public Teacher(TeacheState ws)
        {
            State = ws;
        }
        public TeacheState State { get; set; }
        public void Create()
        {
            State = TeacheState.Create;
        }
        public void Add()
        {
            State = TeacheState.Add;
            MessageBox.Show("Добавлено в лист");
        }
        public void Save()
        {
            State = TeacheState.Save;
            MessageBox.Show("Сохранено");
        }
    }

}
