using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class Form1 : Form
    {

        FirstGruzComp firGruz = new FirstGruzComp("g11111", 30, 6);
        SecondGruzComp secGruz = new SecondGruzComp("g22222", 3, 599);

        public Form1()
        {
            InitializeComponent();

            TreeNode root = new TreeNode("Компании грузоперевозок");
            treeView1.Nodes.Add(root);

            TreeNode c1 = new TreeNode(firGruz.Name);
            TreeNode c2 = new TreeNode(secGruz.Name);

            root.Nodes.AddRange(new TreeNode[] { c1, c2 });
            root.Expand();

            //TreeNode w1Cnt = new TreeNode(firGruz.WorkersCnt.ToString());
            //TreeNode c1Cnt = new TreeNode(firGruz.CarsCnt.ToString());
            //c1.Nodes.Add("Колличество работников: " + w1Cnt.Text);
            //c1.Nodes.Add("Колличество автомобилей: " + c1Cnt.Text);

            TreeNode w2Cnt = new TreeNode(secGruz.WorkersCnt.ToString());
            TreeNode c2Cnt = new TreeNode(secGruz.AvgWeight.ToString());
            c2.Nodes.Add("Колличество работников: " + w2Cnt.Text);
            c2.Nodes.Add("Средняя масса перевезенных грузов: " + c2Cnt.Text);
            
            foreach (var gr in firGruz.GetType().GetMembers())
            {
                c1.Nodes.Add(gr.ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(450, 400);
        }
    }
}
