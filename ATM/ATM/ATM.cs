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

    //This class contains instances of ATM windows and all functionality


    public partial class ATM : Form
    {
        private Account[] ac;//Holds account information that is shared between ATM's
        private MainMenu logFile = new MainMenu(); 
        private int state; //State of the ATM which determines the button functionality
        private int acc; // Determines which acc is being used
        private string inputLabel; // Used for reading in values for passwords
        private int accountAmount;
        public int takenamount;
        private int displaymode;
        private int displaymodeC;
        private int racingindex; // Used for determining which mode the ATM is running in
        private ATM otherATM; // Holds data for ATM that is used
        private Boolean isRacing; // Determines if the ATM is in process of waiting for the other ATM
        
        private Boolean releaseRace;
        private MainMenu system;

        //Constructor for initialising values
        public ATM(Account[] acMain, int index, MainMenu menu)
        {
            racingindex = index;
            system = menu;
            ac = acMain;
            InitializeComponent();
            state = 0;
            acc = -1;
            inputLabel = "";
            accountAmount = 4;
            takenamount = 0;
            isRacing = false;
            displaymode = 0;
            textBox1.ReadOnly = true;
            releaseRace = false;
        }

        //Used for determining the paired ATM's
        public void setOtherATM(ATM other)
        {
            otherATM = other;
        }

        //Number number 1 which is used to input number 1 to the data field.
        private void np1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length < 4 && state == 1) || (textBox1.Text.Length < 6 && state == 0) || state == 3 || state == 7)//Prevents passwords and usernames being too long
            {
                inputLabel = inputLabel + "1";
                textBox1.Clear();
                textBox1.AppendText(inputLabel);
            }
        }

        private void np2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length < 4 && state == 1) || (textBox1.Text.Length < 6 && state == 0) || state == 3 || state == 7)
            {
                inputLabel = inputLabel + "2";
                textBox1.Clear();
                textBox1.AppendText(inputLabel);
            }
        }

        private void np3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length < 4 && state == 1) || (textBox1.Text.Length < 6 && state == 0) || state == 3 || state == 7)
            {
                inputLabel = inputLabel + "3";
                textBox1.Clear();
                textBox1.AppendText(inputLabel);
            }
        }

        private void np4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length < 4 && state == 1) || (textBox1.Text.Length < 6 && state == 0) || state == 3 || state == 7)
            {
                inputLabel = inputLabel + "4";
                textBox1.Clear();
                textBox1.AppendText(inputLabel);
            }
        }

        private void np5_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length < 4 && state == 1) || (textBox1.Text.Length < 6 && state == 0) || state == 3 || state == 7)
            {
                inputLabel = inputLabel + "5";
                textBox1.Clear();
                textBox1.AppendText(inputLabel);
            }
        }

        private void np6_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length < 4 && state == 1) || (textBox1.Text.Length < 6 && state == 0) || state == 3 || state == 7)
            {
                inputLabel = inputLabel + "6";
                textBox1.Clear();
                textBox1.AppendText(inputLabel);
            }
        }

        private void np7_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length < 4 && state == 1) || (textBox1.Text.Length < 6 && state == 0) || state == 3 || state == 7)
            {
                inputLabel = inputLabel + "7";
                textBox1.Clear();
                textBox1.AppendText(inputLabel);
            }
        }

        private void np8_Click_1(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length < 4 && state == 1) || (textBox1.Text.Length < 6 && state == 0) || state == 3 || state == 7)
            {
                inputLabel = inputLabel + "8";
                textBox1.Clear();
                textBox1.AppendText(inputLabel);
            }
        }

        private void np9_Click_1(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length < 4 && state == 1) || (textBox1.Text.Length < 6 && state == 0) || state == 3 || state == 7)
            {
                inputLabel = inputLabel + "9";
                textBox1.Clear();
                textBox1.AppendText(inputLabel);
            }
        }

        private void np0_Click_1(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length < 4 && state == 1) || (textBox1.Text.Length < 6 && state == 0) || state == 3 || state == 7)
            {
                inputLabel = inputLabel + "0";
                textBox1.Clear();
                textBox1.AppendText(inputLabel);
            }
        }



        private void clearScreen()//method used to clear the screen
        {
            inputLabel = String.Empty;
            textBox1.Clear();
            textBox1.AppendText(inputLabel);
        }

        //Button that submits data that was put in with the keypad
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            switch (state)
            {
                case 0://State 0 represents account ID input
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
                case 1: //State 1 represents password input
                    if (textBox1.Text.Length >0) 
                    {
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
                case 3: // Case 3 represents widthdrawal of money
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
                        if (amount % 5 != 0)//Checks if bills that are taken out are divisible by 5.
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
                            widthdrawCash(amount);
                            amountLabel.Visible = false;
                            textBox1.Visible = false;
                            inputLabel = "";
                        }
                    }
                    break;
                    case 7:
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
                        if (amount % 5 != 0)//Checks if bills that are taken out are divisible by 5.
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
                            widthdrawCash(amount);
                            runCheckAnimation();
                            amountLabel.Visible = false;
                            textBox1.Visible = false;
                            inputLabel = "";
                            textBox1.Clear();
                            textBox1.AppendText(inputLabel);
                            
                        }
                    }
                    break;
                default:
                    break;
                }
            }
        
        //Method that is used for redisplaying the starting menu screen
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

        //Cancels current session
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            firstScreen();
            textBox1.PasswordChar = '\0';
        }

        //Removes 1 element from the textbox
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

        //Used for widthdrawing various amounts of cash from the ATM
        private void widthdrawCash(int money)
        {
            if (racingindex == 1 || racingindex == 2)
            {
                //Loop method runs until both of the ATM's are reading to take money out.
                
                loopUntilActive();
                if (racingindex == 2) MainMenu.protection.WaitOne();//racingindex = 2 is a condition for activating semaphore
                Console.Write("got here");
                int tempbalance = ac[acc].getBalance();//Retrieving balance of current account
                Thread.Sleep(2000);//Sleep on both threads enables them to data race between eachother
                tempbalance = tempbalance - money;
                ac[acc].setBalance(tempbalance);//Updating the balance
                if (racingindex == 2) MainMenu.protection.Release();// semaphore is released
                string account = "---> Amount " + money + " has been withdrawn\r\n";
                system.updateLog(account);
                runMoneyAnimation();//Runs the animation for taking money out
                enterStateSecond();
                isRacing = false;
            }
            else
            {   //Check if the money withdrawn is too much for the balance of the user
                int tempbalance = ac[acc].getBalance();
                if (tempbalance < money)
                {
                    insFunds();
                }
                else
                {
                    //Withdrawal of money from a single-ATM mode
                    tempbalance = tempbalance - money;
                    ac[acc].setBalance(tempbalance);
                    string account = "---> Amount " + money + " has been withdrawn\r\n";
                    system.updateLog(account);
                    runMoneyAnimation();
                    enterStateSecond();
                }
            }
        }
        //Bottom left ATM button
        private void btn1_Click(object sender, EventArgs e)
        {
            switch (state)
            {
                case 2:
                    break;
                case 3:
                    widthdrawCash(5);
                    cashLabel.Text = "Exit?";
                    cashLabel.Visible = true;
                    cashLabel.ForeColor = System.Drawing.Color.White;
                    panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("basicBg.jpg");
                    yLabel.Visible = true;
                    nLabel.Visible = true;
                    state = 6;
                    break;
                case 5:
                     cashLabel.Visible = false;
                     amLabel.Visible = false;
                     yLabel.Visible = false;
                     nLabel.Visible = false;
                     questionLabel.Visible = false;
                     enterStateSecond();
                     break;
                case 6:
                     cashLabel.Visible = false;
                     amLabel.Visible = false;
                     yLabel.Visible = false;
                     nLabel.Visible = false;
                     questionLabel.Visible = false;
                     firstScreen();
                     break;
                case 7:
                     widthdrawCash(5);
                     cashLabel.Text = "Exit?";
                     cashLabel.Visible = true;
                     cashLabel.ForeColor = System.Drawing.Color.White;
                     panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("basicBg.jpg");
                     yLabel.Visible = true;
                     nLabel.Visible = true;
                     runCheckAnimation();
                     state = 6;
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

        //Makes sure both data racing ATM's are on cash-withdrawal mode
        private void loopUntilActive()
        
        {
            panel1.Visible = false;
            panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("pausePictur.jpg");
            panel1.Visible = true;
            isRacing = true;

            for (; ; )
            {
                if (isRacing == true && otherATM.getIsRacing() == true) break;//Only ends loop if both ATM's are used
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            switch (state)
            {
                case 2:
                    break;
                case 3:
                    widthdrawCash(50);
                    cashLabel.Text = "Exit?";
                    cashLabel.Visible = true;
                    cashLabel.ForeColor = System.Drawing.Color.White;
                    panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("basicBg.jpg");
                    yLabel.Visible = true;
                    nLabel.Visible = true;
                    state = 6;
                    break;
                case 5:
                    cashLabel.Visible = false;
                    amLabel.Visible = false;
                    yLabel.Visible = false;
                    nLabel.Visible = false;
                    questionLabel.Visible = false;
                    firstScreen();
                    break;
                case 6:
                    cashLabel.Visible = false;
                    amLabel.Visible = false;
                    yLabel.Visible = false;
                    nLabel.Visible = false;
                    questionLabel.Visible = false;
                    enterStateSecond();
                    break;
                case 7:
                    widthdrawCash(50);
                    cashLabel.Text = "Exit?";
                    cashLabel.Visible = true;
                    cashLabel.ForeColor = System.Drawing.Color.White;
                    panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("basicBg.jpg");
                    yLabel.Visible = true;
                    nLabel.Visible = true;
                    runCheckAnimation();
                    state = 6;
                    break;
                default:
                    break;
            }
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
                    widthdrawCash(10);
                    cashLabel.Text = "Exit?";
                    cashLabel.Visible = true;
                    cashLabel.ForeColor = System.Drawing.Color.White;
                    panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("basicBg.jpg");
                    yLabel.Visible = true;
                    nLabel.Visible = true;
                    state = 6;
                    break;
                case 7://Checks if the user wants to do any more actions after money is withdrawn
                    widthdrawCash(10);
                    cashLabel.Text = "Exit?";
                    cashLabel.Visible = true;
                    cashLabel.ForeColor = System.Drawing.Color.White;
                    panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("basicBg.jpg");
                    yLabel.Visible = true;
                    nLabel.Visible = true;
                    runCheckAnimation();
                    state = 6;
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
                    state = 7;
                    panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("amountMenu.png");
                    break;
                case 3:
                    widthdrawCash(100);
                    cashLabel.Text = "Exit?";
                    cashLabel.Visible = true;
                    cashLabel.ForeColor = System.Drawing.Color.White;
                    panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("basicBg.jpg");
                    yLabel.Visible = true;
                    nLabel.Visible = true;
                    state = 6;
                    break;
                case 7:
                    widthdrawCash(100);
                    cashLabel.Text = "Exit?";
                    cashLabel.Visible = true;
                    cashLabel.ForeColor = System.Drawing.Color.White;
                    panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("basicBg.jpg");
                    yLabel.Visible = true;
                    nLabel.Visible = true;
                    runCheckAnimation();
                    state = 6;
                    break;
                default:
                    break;
            }
        }

        //Method that activates when user has insufficient funds
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
                    widthdrawCash(20);
                    cashLabel.Text = "Exit?";
                    cashLabel.Visible = true;
                    cashLabel.ForeColor = System.Drawing.Color.White;
                    panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("basicBg.jpg");
                    yLabel.Visible = true;
                    nLabel.Visible = true;
                    state = 6;
                    break;
                case 7:
                    widthdrawCash(20);
                    cashLabel.Text = "Exit?";
                    cashLabel.Visible = true;
                    cashLabel.ForeColor = System.Drawing.Color.White;
                    panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("basicBg.jpg");
                    yLabel.Visible = true;
                    nLabel.Visible = true;
                    runCheckAnimation();
                    state = 6;
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
                   runCheckAnimation();
                    break;
                case 3:
                    panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("basicBg.jpg");
                    textBox1.PasswordChar = '\0';
                    textBox1.Visible = true;
                    amountLabel.Visible = true;
                    break;
                case 7:
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

        //Method that is used to create backgroundworker to draw money animation
        private void runMoneyAnimation()
        {
            
            BackgroundWorker animator = new BackgroundWorker();
            animator.DoWork += new DoWorkEventHandler(animator_DoWork);
            animator.RunWorkerAsync();
            
        }
        //Method that is used to create backgroundworker to draw cheque animation
        private void runCheckAnimation() 
        {
            BackgroundWorker animatorC = new BackgroundWorker();
            animatorC.DoWork += new DoWorkEventHandler(animatorC_DoWork);
            animatorC.RunWorkerAsync();
        }

        //A loop that runs independently from the main thread. It draws the animation.
        private void animatorC_DoWork(object sender, DoWorkEventArgs e)
        {
            String tempstr;
            if (displaymodeC == 0)
            {
                for (int i = 1; i < 6; i++)
                {
                    tempstr = "CK" + i.ToString() + ".png";
                    pictureBox2.BackgroundImage = System.Drawing.Bitmap.FromFile(tempstr);
                    System.Threading.Thread.Sleep(130);
                }
                displaymodeC = 1;
            }
            else
            {
                for (int i = 1; i > 0; i--)
                {
                    tempstr = "CK" + i.ToString() + ".png";
                    pictureBox2.BackgroundImage = System.Drawing.Bitmap.FromFile(tempstr);
                    System.Threading.Thread.Sleep(130);
                }
                displaymodeC = 0;
            }
        }
        //A loop that runs independently from the main thread. It draws the animation.
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (displaymodeC == 1) 
            {
                runCheckAnimation();
            }
        }
    }
}

