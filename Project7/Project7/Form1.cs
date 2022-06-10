using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Project4
{
    public delegate void Deleg(TreeNode c1);

    public partial class Form1 : Form
    {
        private static System.Timers.Timer aTimer;

        Stack<Company> myStack = new Stack<Company>();

        public Form1()
        {
            InitializeComponent();

            TreeNode root = new TreeNode("Компании грузоперевозок");
            treeView1.Nodes.Add(root);

            SetTimer();
            aTimer.Start();

            Company.Notify += DisplayMessage;

            void SetTimer()
            {
                aTimer = new System.Timers.Timer(5000);
                aTimer.Elapsed += OnTimedEvent;
                aTimer.AutoReset = true;
                aTimer.Enabled = true;
            }

            void addRoot(TreeNode c1)
            {
                root.Nodes.Add(c1);
                root.Expand();
            }

            void addNode(TreeNode c1)
            {
                try
                {
                    FirstGruzComp GruzTest = (FirstGruzComp)myStack.Peek();
                    TreeNode w2Cnt = new TreeNode(GruzTest.WorkersCnt.ToString());
                    TreeNode c2Cnt = new TreeNode(GruzTest.CarsCnt.ToString());
                    c1.Nodes.Add("Колличество работников: " + w2Cnt.Text);
                    c1.Nodes.Add("Колличество автомобилей: " + c2Cnt.Text);
                }
                catch
                {
                    SecondGruzComp sGruzTest = (SecondGruzComp)myStack.Peek();
                    TreeNode w2Cnt = new TreeNode(sGruzTest.WorkersCnt.ToString());
                    TreeNode c2Cnt = new TreeNode(sGruzTest.AvgWeight.ToString());
                    c1.Nodes.Add("Колличество работников: " + w2Cnt.Text);
                    c1.Nodes.Add("Средняя масса перевезенных грузов: " + c2Cnt.Text);
                }
            }

            void OnTimedEvent(Object source, ElapsedEventArgs e)
            {
                myStack += GenComp();
                TreeNode c1 = new TreeNode(myStack.Peek().Name);
                Deleg deleg1 = new Deleg(addRoot);
                Invoke(deleg1, c1);
                deleg1 = addNode;
                Invoke(deleg1, c1);
            }
        }
        void DisplayMessage(string message) => MessageBox.Show(message);

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(450, 400);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (myStack.Count != 0)
                {
                    myStack -= myStack.Peek();
                    TreeNode tn = treeView1.Nodes[0];
                    tn.Nodes.Remove(tn.LastNode);
                }
                else
                {
                    throw new emptyStackException();
                }
            }
            catch
            {
                ExMessage();
            }
        }
        static Company GenComp()
        {
            var rnd = new Random();
            var random = rnd.Next(0, 2);
            if (random == 1)
            {
                random = rnd.Next(1, 128);
                FirstGruzComp newComp = new FirstGruzComp(
                       name: String_Generation(),
                       workersCnt: random * 3,
                       carsCnt: random - 8
                    );
                newComp++;
                return newComp;
            }
            else
            {
                random = rnd.Next(1, 128);
                SecondGruzComp newComp = new SecondGruzComp(
                       name: String_Generation(),
                       workersCnt: random * 3,
                       avgWeight: random * 10
                    );
                newComp++;
                return newComp;
            }

        }

        private static string String_Generation()
        {
            var rnd = new Random();
            var pwdChars = new Char[12] { 'Г', 'М', 'Д', 'A', 'Ж', 'Э', 'Ч', 'E', 'Ф', '5', '3', '8' };
            var str = String.Empty;
            for (int i = 0; i < 10; i++)
            {
                str += pwdChars[rnd.Next(0, 11)];
            }
            return str;
        }
        public static void ExMessage()
        {
            MessageBox.Show("Невозможно удалить элемент из пустой коллекции!", "Вызвано исключение!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                myStackOverflowException();
            }
            catch 
            {
                MessageBox.Show("Переполнен стек выполнения!", "Вызвано исключение!");
            }
        }
        public static void myStackOverflowException()
        {
            try
            {
                throw new StackOverflowException();
            }
            catch
            {
                MessageBox.Show("Переполнен стек выполнения!", "Вызвано исключение!");
            }
        }

        class overflowStackException : Exception
        {
            public overflowStackException()
            {
                MessageBox.Show("Переполнен стек выполнения!", "Вызвано исключение!");
            }
        }

        class emptyStackException : Exception
        {
            public emptyStackException()
            {
            }
        }
    }
}
