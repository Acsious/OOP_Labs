using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    static class Program
    {
        [STAThread] // однопоточный режим
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeForm()); // приветственное окошко
            Application.Run(new Form1()); // главное окно
        }
    }
}
