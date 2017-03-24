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
        private int testingstate;
        private Account[] ac = new Account[4];//Storing accounts in an array
        ATM test;
        ATM test2;
        private Thread tester1, tester2;
        public static Semaphore protection;//Semaphore storage
        public MainMenu()
        {
            InitializeComponent();
            protection = new Semaphore(1,1);//Semaphore is determined to only hold 1 Thread at a time in the specified space
            ac[1] = new Account(300, 1111, 111111);
            ac[2] = new Account(750, 2222, 222222);
            ac[3] = new Account(3000, 3333, 333333);
            mainBox.ReadOnly = true;

        }
        //Creates a single thread for an ATM to be used
        private void button1_Click(object sender, EventArgs e)
        {
            testingstate = 0;
            test = new ATM(ac, testingstate, this);//Calls the constructor to fill in ATM object
            ThreadStart work = new ThreadStart(workThread);
            Thread runwork = new Thread(work);
            runwork.Start();//Runs the thread for a new instance of ATM
            string text = "---> ATM WAS OPENED";
            mainBox.AppendText(text);
            mainBox.AppendText(Environment.NewLine);
            
        }

        public void updateLog(String message) 
        {
            try
            {
                mainBox.Invoke(new Action(() => mainBox.AppendText(message)));
            }
            catch (Exception eee)
            {

            }
        }
        //Data racing without semaphores
        private void button2_Click(object sender, EventArgs e)
        {
            testingstate = 1;
            test = new ATM(ac, testingstate, this);
            test2 = new ATM(ac, testingstate, this);
            test.setOtherATM(test2);
            test2.setOtherATM(test);
            ThreadStart workracing1 = new ThreadStart(workThread);
            tester1 = new Thread(workracing1);
            tester1.Start();
            ThreadStart workracing2 = new ThreadStart(workThread2);
            tester2 = new Thread(workracing2);
            tester2.Start();
            string text = "---> TWO ATMS OPENED FOR TESTING";
            mainBox.AppendText(text);
            mainBox.AppendText(Environment.NewLine);
        }

        private void workThread()
        {
            test.ShowDialog();
        }

        private void workThread2()
        {
            test2.ShowDialog();
        }
        //Activated to enable data racing with semaphores
        private void button3_Click(object sender, EventArgs e)
        {
            testingstate = 2;
            test = new ATM(ac, testingstate, this);
            test2 = new ATM(ac, testingstate, this);
            test.setOtherATM(test2);
            test2.setOtherATM(test);
            ThreadStart workracing1 = new ThreadStart(workThread);
            tester1 = new Thread(workracing1);
            tester1.Start();
            ThreadStart workracing2 = new ThreadStart(workThread2);
            tester2 = new Thread(workracing2);
            tester2.Start();
            string text = "---> TWO ATMS OPENED FOR TESTING";
            mainBox.AppendText(text);
            mainBox.AppendText(Environment.NewLine);
        }
    }
    public class Account
    {
        //the attributes for the account
        private int balance;
        private int pin;
        private int accountNum;

        // a constructor that takes initial values for each of the attributes (balance, pin, accountNumber)
        public Account(int balance, int pin, int accountNum)
        {
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
        }

        //getter and setter functions for balance
        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }

        public Boolean checkPin(int pinEntered)
        {
            if (pinEntered == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getAccountNum()
        {
            return accountNum;
        }
    }
}
