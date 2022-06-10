using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            WelcomeForm.Run(this);
        }
        public Form1()
        {
            InitializeComponent();
            textBox2.KeyPress += new KeyPressEventHandler(textBox2_KeyPress);
            textBox3.KeyPress += new KeyPressEventHandler(textBox3_KeyPress);
            textBox4.KeyPress += new KeyPressEventHandler(textBox4_KeyPress);
            textBox5.KeyPress += new KeyPressEventHandler(textBox5_KeyPress);
            textBox6.KeyPress += new KeyPressEventHandler(textBox6_KeyPress);

            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
        }
    }
    
}
