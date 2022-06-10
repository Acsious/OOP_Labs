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
}
