using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_1
{
    static class Program
    {
        [STAThread]//���� � winforms, ��� ���. ���������� ���. �����������
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();//�����, ������, ���.��-��
            Application.SetCompatibleTextRenderingDefault(false);///����������� �����.������ �� �����
           ///���.��-�� ���. �����.����� � ���. ����� ������� GDI+
            Application.Run(new calculator());///������
        }
    }
}
