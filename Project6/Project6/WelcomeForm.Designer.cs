using System;
using System.Windows.Forms;

namespace Project4
{
    public partial class WelcomeForm : Form
    {
        static private Form Sender;

        static public void Run(Form sender)
        {
            if (sender == null)
                throw new ArgumentNullException();
            Sender = sender;
            new WelcomeForm().ShowDialog();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}