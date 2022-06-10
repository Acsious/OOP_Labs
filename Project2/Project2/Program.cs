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
        
        [STAThread] // однопоточный режим
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
            Application.Run(new WelcomeForm()); // приветственное окошко
            Application.Run(new Form1()); // главное окно
        }

    }

    //static class Program1
    //{
    //    [STAThread] // однопоточный режим
    //    static void Main()
    //    {
    //        Console.WriteLine("Лабораторная работа по ООП" +
    //            "\nВариант 8: Фирма грузоперевозок" +
    //            "\nВыполнили ст-ты гр. 20ВП1: Ульченко Ф.С. и Нешкин Д.А.\n");
    //        Gruz gruz = new Gruz("gruuuuuz");
    //        Console.WriteLine(gruz.ToString());
    //        Gruz gruz58 = new Gruz(999, 100000, 122, 2, "g58", 12);
    //        Console.WriteLine(gruz58.ToString());
    //        Console.WriteLine("Количество работников представленное в шестнадцатиричной системе счисления: " + Convert.ToString(gruz58.getWorkersCnt(), 16) + "\n");
    //        gruz.setAverageWeight(100);
    //        Console.WriteLine("Средний вес перевозимого груза: " + gruz.getAverageWeight() + "\n");
    //        gruz.printName();
    //        //System.Console.WriteLine("Количество объектов класса Gruz: " + gruz58.getCntObj());
            
            
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
