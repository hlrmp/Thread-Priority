using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBasicThread1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RUN_Click(object sender, EventArgs e)
        {
            Console.WriteLine("- Before Starting Thread -");

            ThreadStart delthread = new ThreadStart(MyThreadClass.Thread1);

            ThreadStart delthread2 = new ThreadStart(MyThreadClass.Thread2);

            Thread ThreadA = new Thread(delthread);
            ThreadA.Name = "Thread A process = ";


            Thread ThreadB = new Thread(delthread2);
            ThreadB.Name = "Thread B process = ";


            Thread ThreadC = new Thread(delthread);
            ThreadC.Name = "Thread C process = ";


            Thread ThreadD = new Thread(delthread2);
            ThreadD.Name = "Thread D process = ";

            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;


            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

           

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();


           





            Console.WriteLine("- End of Thread -");

            label1.Text = " - End of Thread - ";
        }
    }
}
