using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Project4
{
    public delegate void Deleg(TreeNode c1);

    public partial class Form1 : Form
    {
        string path = "dataBase.txt";

        ObobshenniyClass<Company> obClass = new ObobshenniyClass<Company>();

        public Form1()
        {
            InitializeComponent();
            zapolStak();
            testFunk();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(450, 400);
        }

        /// <summary>
        /// Подсчет компаний где больше 100 работников, название начинается на В
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter("1_test.txt");
            var bigComps = obClass.MyStack.Where(comp => comp.WorkersCnt > 100)
                .Where(comp => comp.Name.StartsWith("B"))
                .Count();

            f.WriteLine(bigComps);
            f.Close();
        }

        /// <summary>
        /// Упорядоченные в обратном порядке компании в которых более 100 работников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter("2_test.txt");
            var bigComps = obClass.MyStack.Where(comp => comp.WorkersCnt > 100)
                .OrderBy(comp => comp)
                .Reverse();

            foreach (var com in bigComps)
            {
                try
                {
                    FirstGruzComp GruzTest = (FirstGruzComp)com;
                    f.WriteLine(GruzTest.Name + " " + GruzTest.WorkersCnt + " " + GruzTest.CarsCnt);
                }
                catch
                {
                    SecondGruzComp sGruzTest = (SecondGruzComp)com;
                    f.WriteLine(sGruzTest.Name + " " + sGruzTest.WorkersCnt + " " + sGruzTest.AvgWeight);
                }
            }
            f.Close();
        }

        /// <summary>
        /// Упорядочивание в алфовитном порядке компаний с названием на А и кол-вом работников менее 200
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter("3_test.txt");
            var bigComps = obClass.MyStack.Where(comp => comp.Name.StartsWith("A"))
                .Where(comp => comp.WorkersCnt < 200)
                .OrderBy(comp => comp.WorkersCnt);

            foreach (var com in bigComps)
            {
                try
                {
                    FirstGruzComp GruzTest = (FirstGruzComp)com;
                    f.WriteLine(GruzTest.Name + " " + GruzTest.WorkersCnt + " " + GruzTest.CarsCnt);
                }
                catch
                {
                    SecondGruzComp sGruzTest = (SecondGruzComp)com;
                    f.WriteLine(sGruzTest.Name + " " + sGruzTest.WorkersCnt + " " + sGruzTest.AvgWeight);
                }
            }
            f.Close();
        }

        /// <summary>
        /// Суммарное кол-во работников в компаниях на В и числом работников более 100
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter("4_test.txt");
            var bigComps = obClass.MyStack.Where(comp => comp.WorkersCnt > 100)
                .Where(comp => comp.Name.StartsWith("B"))
                .Sum(comp => comp.WorkersCnt);

            f.WriteLine(bigComps);
            f.Close();
        }

        /// <summary>
        /// Поиск компании с минимальным числом работников среди тех в котрых работает более 100 человек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter("5_test.txt");
            var bigComps = obClass.MyStack.Distinct()
            .Where(comp => comp.WorkersCnt > 100)
            .Min(comp => comp.WorkersCnt);

            f.WriteLine(bigComps);
            f.Close();
        }

        /// <summary>
        /// Функция считывающая данные из исходного файла
        /// </summary>
        void zapolStak()
        {
            var rnd = new Random();
            string s;
            StreamReader f = new StreamReader(path);
            while ((s = f.ReadLine()) != null)
            {
                string[] words = s.Split(new char[] { ' ' });
                var random = rnd.Next(0, 2);
                if (random == 1)
                {
                    random = rnd.Next(1, 128);
                    FirstGruzComp newComp = new FirstGruzComp(
                           name: words[0].ToUpper(),
                           workersCnt: Int32.Parse(words[1]),
                           carsCnt: Int32.Parse(words[2])
                        ); ;
                    newComp++;
                    obClass.MyStack.Push(newComp);
                }
                else
                {
                    random = rnd.Next(1, 128);
                    SecondGruzComp newComp = new SecondGruzComp(
                           name: words[0].ToUpper(),
                           workersCnt: Int32.Parse(words[1]),
                           avgWeight: Int32.Parse(words[2])
                        );
                    newComp++;
                    obClass.MyStack.Push(newComp);
                }
            }
            f.Close();
        }


        void testFunk()
        {
            int n = 4;
            var marr = new ObobshenniyClass<Company>[n];
            var rnd = new Random();

            ///заполнение массива
            for (int i = 0; i < n; i++)
            {
                marr[i] = new ObobshenniyClass<Company>();

                var random = rnd.Next(0, 2);
                if (random == 1)
                {
                    random = rnd.Next(1, 5);
                    for (int j = 0; j < random; j++)
                    {
                        FirstGruzComp newComp = new FirstGruzComp(
                               name: "FFMASS" + random * 3 + 3 * j * i + j,
                               workersCnt: random * 3 + 30 - 1 * j + random + j,
                               carsCnt: random * 3 + 30 * 3 + j + random
                            );
                        marr[i].MyList.AddLast(newComp);
                    }
                }
                else
                {
                    random = rnd.Next(1, 5);
                    for (int j = 0; j < random; j++)
                    {
                        SecondGruzComp newComp = new SecondGruzComp(
                           name: "SSMASS" + random * 4 + 4 * i + j,
                               workersCnt: random * 4 + 40 - 1 + random + j,
                           avgWeight: random * 4 + 40 * 4 + random + j
                        );
                        marr[i].MyList.AddLast(newComp);
                    }
                }
            }

            var nSize = marr.Where(com => com.MyList.Count == 3);
            
            var maxLen = marr.Select(lst => lst.MyList.Count).Max();
            var maxElem = marr.Select(lst => lst).Where(lst=>lst.MyList.Count==maxLen).First();

            var minLen = marr.Select(lst => lst.MyList.Count).Min();
            var minElem = marr.Select(lst => lst).Where(lst => lst.MyList.Count == minLen).First();


            StreamWriter w = new StreamWriter("mass_test.txt");

            w.WriteLine("Коллекции хранящие по N элементов тест");
            foreach (var ns in nSize)
            {
                foreach (var ml in ns.MyList)
                {
                    try
                    {
                        FirstGruzComp GruzTest = (FirstGruzComp)ml;
                        w.WriteLine(GruzTest.Name + " " + GruzTest.WorkersCnt + " " + GruzTest.CarsCnt);
                    }
                    catch
                    {
                        SecondGruzComp sGruzTest = (SecondGruzComp)ml;
                        w.WriteLine(sGruzTest.Name + " " + sGruzTest.WorkersCnt + " " + sGruzTest.AvgWeight);
                    }
                }

            }

            w.WriteLine("Наибольшая коллекция");
            foreach (var maxE in maxElem.MyList)
            {
                try
                {
                    FirstGruzComp GruzTest = (FirstGruzComp)maxE;
                    w.WriteLine(GruzTest.Name + " " + GruzTest.WorkersCnt + " " + GruzTest.CarsCnt);
                }
                catch
                {
                    SecondGruzComp sGruzTest = (SecondGruzComp)maxE;
                    w.WriteLine(sGruzTest.Name + " " + sGruzTest.WorkersCnt + " " + sGruzTest.AvgWeight);
                }
            }

            w.WriteLine("Наименьшая коллекция");
            foreach (var minE in minElem.MyList)
            {
                try
                {
                    FirstGruzComp GruzTest = (FirstGruzComp)minE;
                    w.WriteLine(GruzTest.Name + " " + GruzTest.WorkersCnt + " " + GruzTest.CarsCnt);
                }
                catch
                {
                    SecondGruzComp sGruzTest = (SecondGruzComp)minE;
                    w.WriteLine(sGruzTest.Name + " " + sGruzTest.WorkersCnt + " " + sGruzTest.AvgWeight);
                }
            }
            w.Close();
        }
    }
}
