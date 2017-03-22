using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ATM
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart work = new ThreadStart(workThread);
            Thread test = new Thread(work);
            test.Start();
            
        }
        private void workThread()
        {
            Form1 test = new Form1();
            test.ShowDialog();
        }
    }
}
