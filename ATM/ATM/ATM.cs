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

    public partial class ATM : Form
    {
        private Account[] ac;
        private MainMenu logFile = new MainMenu();
        private int state;
        private int acc;
        private string inputLabel;
        private int accountAmount;
        public int takenamount;
        private int displaymode;
        private int racingindex;
        private ATM otherATM;
        private Boolean isRacing;
        private Semaphore protection;
        private Boolean releaseRace;
        private Boolean wasInterrupted;
        private BackgroundWorker testbg;
        private MainMenu system;
        private static readonly Object obj = new Object();
        Thread otherThread;
        public ATM(Account[] acMain, int index, MainMenu menu)
        {
            protection = new Semaphore(1, 1);
            racingindex = index;
            system = menu;
            ac = acMain;
            InitializeComponent();
            state = 0;
            acc = -1;
            wasInterrupted = false;
            inputLabel = "";
            accountAmount = 4;
            takenamount = 0;
            isRacing = false;
            displaymode = 0;
            textBox1.ReadOnly = true;
            releaseRace = false;
        }

        public void setOtherATM(ATM other)
        {
            otherATM = other;
        }

        private void np1_Click(object sender, EventArgs e)
        {
            inputLabel = inputLabel + "1";
            textBox1.Clear();

            textBox1.AppendText(inputLabel);
        }

        private void np2_Click(object sender, EventArgs e)
        {
            inputLabel = inputLabel + "2";
            textBox1.Clear();
            textBox1.AppendText(inputLabel);
        }

        public void setOtherThread(Thread tempthread)
        {
            otherThread = tempthread;
        }

        public BackgroundWorker getBG()
        {
            return testbg;
        }

        private void np3_Click(object sender, EventArgs e)
        {
            inputLabel = inputLabel + "3";
            textBox1.Clear();
            textBox1.AppendText(inputLabel);
        }

        private void np4_Click(object sender, EventArgs e)
        {
            inputLabel = inputLabel + "4";
            textBox1.Clear();
            textBox1.AppendText(inputLabel);
        }

        private void np5_Click(object sender, EventArgs e)
        {
            inputLabel = inputLabel + "5";
            textBox1.Clear();
            textBox1.AppendText(inputLabel);
        }

        private void np6_Click(object sender, EventArgs e)
        {
            inputLabel = inputLabel + "6";
            textBox1.Clear();
            textBox1.AppendText(inputLabel);
        }

        private void np7_Click(object sender, EventArgs e)
        {
            inputLabel = inputLabel + "7";
            textBox1.Clear();
            textBox1.AppendText(inputLabel);
        }

        private void np8_Click_1(object sender, EventArgs e)
        {
            inputLabel = inputLabel + "8";
            textBox1.Clear();
            textBox1.AppendText(inputLabel);
        }

        private void np9_Click_1(object sender, EventArgs e)
        {
            inputLabel = inputLabel + "9";
            textBox1.Clear();
            textBox1.AppendText(inputLabel);
        }

        private void np0_Click_1(object sender, EventArgs e)
        {
            inputLabel = inputLabel + "0";
            textBox1.Clear();
            textBox1.AppendText(inputLabel);
        }



        private void clearScreen()//method used to clear the screen
        {
            inputLabel = String.Empty;
            textBox1.Clear();
            textBox1.AppendText(inputLabel);
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            switch (state)
            {
                case 0:
                    string tempacc;
                    for (int i = 1; i < accountAmount; i++)
                    {
                        tempacc = ac[i].getAccountNum().ToString();
                        Console.WriteLine(tempacc);
                        if (inputLabel == tempacc)
                        {
                            state = 1;
                            acc = i;
                            clearScreen();
                            label1.Text = "INSERT PIN:";
                            textBox1.PasswordChar = '*';
                            break;
                        }
                        else if(i==accountAmount-1)
                        {
                            inputLabel = "NO ACCOUNT FOUND";
                            textBox1.Clear();
                            textBox1.AppendText(inputLabel);
                            System.Threading.Thread.Sleep(1000);
                            firstScreen();
                        }
                    }
                    break;
                case 1:
                    if (ac[acc].checkPin(Int32.Parse(inputLabel)) == true)//crashes when pin is empty
                    {
                        clearScreen();
                        string account = "---> Account " + acc + " has logged in\r\n";
                        system.updateLog(account);
                        label1.Visible = false;
                        textBox1.Visible = false;
                        textBox1.PasswordChar = '\0';
                        enterStateSecond();
                    }
                    else
                    {
                        textBox1.PasswordChar = '\0';
                        inputLabel = "Wrong password!...";
                        textBox1.Clear();
                        textBox1.AppendText(inputLabel);
                        System.Threading.Thread.Sleep(2000);
                        textBox1.Clear();
                        inputLabel = "";
                        label1.Text = "ACCOUNT NUMBER:";
                        state = 0;
                    }
                    break;
                case 3:
                    if (textBox1.Text == null || textBox1.Text=="")
                    {
                        inputLabel = "Invalid value!";
                        textBox1.Clear();
                        textBox1.AppendText(inputLabel);
                        System.Threading.Thread.Sleep(2000);
                        state = 0;
                        firstScreen();

                    }
                    else
                    {
                        int amount = Int32.Parse(textBox1.Text);
                        int tempalance = ac[acc].getBalance();
                        if (amount % 5 != 0)
                        {
                            inputLabel = "Invalid amount...";
                            textBox1.Clear();
                            textBox1.AppendText(inputLabel);
                            System.Threading.Thread.Sleep(2000);
                            firstScreen();

                        }
                        else if (tempalance < amount)
                        {
                            inputLabel = "Insufficient funds...";
                            textBox1.Clear();
                            textBox1.AppendText(inputLabel);
                            System.Threading.Thread.Sleep(2000);
                            firstScreen();
                        }
                        else
                        {
                            int tempbalance = ac[acc].getBalance();
                            if (racingindex == 1) loopUntilActive();
                            tempbalance = tempbalance - amount;
                            ac[acc].setBalance(tempbalance);
                            string account = "---> Amount " + amount + " has been withdrawn\r\n";
                            system.updateLog(account);
                            runMoneyAnimation();
                            enterStateSecond();
                            amountLabel.Visible = false;
                            textBox1.Visible = false;
                            inputLabel = "";
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void firstScreen() 
        {
            amountLabel.Visible = false;
            inputLabel = String.Empty;
            textBox1.Clear();
            textBox1.AppendText(inputLabel);
            state = 0;
            label1.Text = "ACCOUNT NUMBER:";
            label1.Visible = true;
            textBox1.Visible = true;
            panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("bgImage.jpg");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            firstScreen();
            textBox1.PasswordChar = '\0';
        }

        private void correctionBtn_Click(object sender, EventArgs e)
        {
            if (inputLabel.Length > 0)
            {
                inputLabel = inputLabel.Remove(inputLabel.Length - 1);
            }
            textBox1.Clear();
            textBox1.AppendText(inputLabel);
        }





        private void ATM_Load(object sender, EventArgs e)
        {

        }



        private void btn1_Click(object sender, EventArgs e)
        {
            switch (state)
            {
                case 2:
                    break;
                case 3:
                    if (racingindex == 1) loopUntilActive();
                    else
                    {
                        int tempbalance = ac[acc].getBalance();
                        if (tempbalance < 5)
                        {
                            insFunds();
                        }
                        else
                        {
                            tempbalance = tempbalance - 5;
                            ac[acc].setBalance(tempbalance);
                            string account = "---> Amount " + 5 + " has been withdrawn\r\n";
                            system.updateLog(account);
                            //ac[acc].decrementBalance(5);
                            //wasInterrupted = false;
                            runMoneyAnimation();
                            enterStateSecond();
                        }
                    }
                    break;
                case 5:
                     cashLabel.Visible = false;
                     amLabel.Visible = false;
                     yLabel.Visible = false;
                     nLabel.Visible = false;
                     questionLabel.Visible = false;
                     enterStateSecond();
                     break;
                default:
                    break;
            }
        }

        private Boolean getIsRacing()
        {
            return isRacing;
        }

        private Boolean getReleaseRace()
        {
            return releaseRace;
        }

        private void loopUntilActive()
        {
            int tempbalance = 0;
            isRacing = true;
            if (otherATM.getIsRacing() == true) otherThread.Interrupt();
            //protection.WaitOne();

            try
            {
                
                System.Threading.Thread.Sleep(9999999);
                
              
                
                

            }
            catch (ThreadInterruptedException ex)
            {
                System.Threading.Thread.Sleep(1000);
                otherThread.Interrupt();
                //protection.WaitOne();
                tempbalance = ac[acc].getBalance();
                
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine(this.Text);
                tempbalance = tempbalance - 5;
                ac[acc].setBalance(tempbalance);
                //protection.Release();
                isRacing = false;
                


                //protection.Release();

            }
            runMoneyAnimation();
            enterStateSecond();
            /*for (; ; )
            {
                if (isRacing == true && otherATM.getIsRacing() == true)
                {
                    releaseRace = true;
                    break;
                }
                if (releaseRace == true || otherATM.getReleaseRace() == true)
                {
                    break;
                }
            }
            isRacing = false;*/

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            switch (state)
            {
                case 2:
                    break;
                case 3:
                    int tempbalance = ac[acc].getBalance();
                    if (racingindex == 1) loopUntilActive();
                    if (tempbalance < 50)
                    {
                        insFunds();
                    }
                    else
                    {
                        tempbalance = tempbalance - 50;
                        ac[acc].setBalance(tempbalance);
                        string account = "---> Amount " + 50 + " has been withdrawn\r\n";
                        system.updateLog(account);
                        runMoneyAnimation();
                        enterStateSecond();
                    }
                    break;
                case 5:
                    cashLabel.Visible = false;
                    amLabel.Visible = false;
                    yLabel.Visible = false;
                    nLabel.Visible = false;
                    questionLabel.Visible = false;
                    firstScreen();
                    break;
                default:
                    break;
            }
        }

        private void setWasInterrupted(Boolean intr)
        {
            wasInterrupted = intr;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            switch (state)
            {
                case 2:
                    state = 3;
                    panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("amountMenu.png");
                    break;
                case 3:
                    int tempbalance = ac[acc].getBalance();
                    if (racingindex == 1) loopUntilActive();
                    if (tempbalance < 10)
                    {
                        insFunds();
                    }
                    else
                    {
                        tempbalance = tempbalance - 10;
                        ac[acc].setBalance(tempbalance);
                        string account = "---> Amount " + 10 + " has been withdrawn\r\n";
                        system.updateLog(account);
                        runMoneyAnimation();
                        enterStateSecond();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            switch(state)
            {
                case 2:
                    state = 3;
                    panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("amountMenu.png");
                    break;
                case 3:
                    int tempbalance = ac[acc].getBalance();
                    if (racingindex == 1) loopUntilActive();
                    if (tempbalance < 100)
                    {
                        insFunds();
                    }
                    else
                    {
                        tempbalance = tempbalance - 100;
                        ac[acc].setBalance(tempbalance);
                        string account = "---> Amount " + 100 + " has been withdrawn\r\n";
                        system.updateLog(account);
                        runMoneyAnimation();
                        enterStateSecond();
                    }
                    break;
                default:
                    break;
            }
        }

        private void insFunds() 
        {
            panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("bgImage.jpg");
            textBox1.Visible = true;
            inputLabel = "Insufficient funds...";
            textBox1.Clear();
            textBox1.AppendText(inputLabel);
            System.Threading.Thread.Sleep(2000);
            firstScreen();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            switch (state)
            {
                case 2:
                    cashLabel.Text = ac[acc].getBalance().ToString();
                    cashLabel.Visible = true;
                    cashLabel.ForeColor = System.Drawing.Color.White;
                    amLabel.Visible = true;
                    panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("basicBg.jpg");
                    yLabel.Visible = true;
                    nLabel.Visible = true;
                    questionLabel.Visible = true;
                    state = 5;//state for checking money left
                    string account = "---> £" + ac[acc].getBalance().ToString() + " left in the account\r\n";
                    system.updateLog(account);
                    break;
                case 3:
                    int tempbalance = ac[acc].getBalance();
                    if (racingindex == 1) loopUntilActive();
                    if (tempbalance < 20)
                    {
                        insFunds();
                    }
                    else
                    {
                        tempbalance = tempbalance - 20;
                        ac[acc].setBalance(tempbalance);
                        string accountt = "---> Amount " + 20 + " has been withdrawn\r\n";
                        system.updateLog(accountt);
                        runMoneyAnimation();
                        enterStateSecond();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            switch (state)
            {
                case 2:
                    break;
                case 3:
                    panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("basicBg.jpg");
                    textBox1.PasswordChar = '\0';
                    textBox1.Visible = true;
                    amountLabel.Visible = true;
                    break;
                default:
                    break;
            }
        }
        private void enterStateSecond()
        {
            state = 2;
            panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("atmMenu.png");
        }

        private void runMoneyAnimation()
        {
            
            BackgroundWorker animator = new BackgroundWorker();
            animator.DoWork += new DoWorkEventHandler(animator_DoWork);
            animator.RunWorkerAsync();
            
        }
        private void animator_DoWork(object sender, DoWorkEventArgs e)
        {
            String tempstr;
            if (displaymode == 0)
            {
                for (int i = 1; i < 11; i++)
                {
                    tempstr = "openATM" + i.ToString() + ".png";
                    pictureBox1.BackgroundImage = System.Drawing.Bitmap.FromFile(tempstr);
                    System.Threading.Thread.Sleep(130);
                }
                displaymode = 1;
            }
            else
            {
                for (int i = 6; i > 0; i--)
                {
                    tempstr = "openATM" + i.ToString() + ".png";
                    pictureBox1.BackgroundImage = System.Drawing.Bitmap.FromFile(tempstr);
                    System.Threading.Thread.Sleep(130);
                }
                displaymode = 0;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (displaymode == 1)
            {
                runMoneyAnimation();
            }
        }
    }
}

