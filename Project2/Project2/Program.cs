using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    static class Program
    {
        
        [STAThread] // ������������ �����
        static void Main()
        {
            //var myStack = new Stack<Gruz>();
            //Gruz gruz = new Gruz("gruuuuuz");
            //Gruz gruz58 = new Gruz(999, 100000, 10, 2, "g58", 12);
            //myStack.Push(gruz);
            //myStack.Push(gruz58);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeForm()); // �������������� ������
            Application.Run(new Form1()); // ������� ����
        }

    }

    //static class Program1
    //{
    //    [STAThread] // ������������ �����
    //    static void Main()
    //    {
    //        Console.WriteLine("������������ ������ �� ���" +
    //            "\n������� 8: ����� ��������������" +
    //            "\n��������� ��-�� ��. 20��1: �������� �.�. � ������ �.�.\n");
    //        Gruz gruz = new Gruz("gruuuuuz");
    //        Console.WriteLine(gruz.ToString());
    //        Gruz gruz58 = new Gruz(999, 100000, 122, 2, "g58", 12);
    //        Console.WriteLine(gruz58.ToString());
    //        Console.WriteLine("���������� ���������� �������������� � ����������������� ������� ���������: " + Convert.ToString(gruz58.getWorkersCnt(), 16) + "\n");
    //        gruz.setAverageWeight(100);
    //        Console.WriteLine("������� ��� ������������ �����: " + gruz.getAverageWeight() + "\n");
    //        gruz.printName();
    //        //System.Console.WriteLine("���������� �������� ������ Gruz: " + gruz58.getCntObj());
            
            
    //        var myStack = new Stack<Gruz>();
    //        myStack.Push(gruz);
    //        myStack.Push(gruz58);
    //        foreach (Gruz gruz3 in myStack)
    //        {
    //            Console.WriteLine(gruz3);
    //        }
            
    //    }
    //}
}
