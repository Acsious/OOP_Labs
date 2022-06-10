
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace Project4
{
    partial class Form1
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
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
                //Form1.exMessage();
                //Win32.MessageBox(0, "Hello World", "Platform Invoke Sample", 0);
                //MessageBox.Show("Невозможно удалить элемент из пустой коллекции!");
            }
        }
 
        class emptyStackException : Exception
        {
            public emptyStackException()
            {
                //MessageBox.show("Невозможно удалить элемент из пустой коллекции!");
            }

            public emptyStackException(string message) : base(message) {  }

            public emptyStackException(string message, Exception inner) : base(message, inner) {  }

            protected emptyStackException(SerializationInfo info, StreamingContext context) : base(info, context) {  }
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Информация о компаниях грузоперевозок";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(3, 33);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(368, 376);
            this.treeView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Удалить последнюю компанию из коллекции";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ООП Лаб.4 Вар.8 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
    }
}

