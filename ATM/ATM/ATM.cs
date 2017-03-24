using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{

    public partial class ATM : Form
    {
        private Account[] ac;
        private int state;
        private int acc;
        private string inputLabel;
        private int accountAmount;
        public int takenamount;
        private int displaymode;
        public ATM(Account[] acMain)
        {
            ac = acMain;
            InitializeComponent();
            state = 0;
            acc = -1;
            inputLabel = "";
            accountAmount = 3;
            takenamount = 0;
            displaymode = 0;
            textBox1.ReadOnly = true;
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
                    for (int i = 0; i < accountAmount; i++)
                    {
                        tempacc = ac[i].getAccountNum().ToString();
                        if (inputLabel == tempacc)
                        {
                            state = 1;
                            acc = i;
                            clearScreen();
                            //label1.TextAlign.
                            label1.Text = "INSERT PIN:";
                            textBox1.PasswordChar = '*';
                            break;
                        }
                    }
                    break;
                case 1:
                    if (ac[acc].checkPin(Int32.Parse(inputLabel)) == true)
                    {
                        clearScreen();
                        label1.Visible = false;
                        textBox1.Visible = false;
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
                    enterStateSecond();
                    break;
                default:
                    break;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            inputLabel = String.Empty;
            textBox1.Clear();
            textBox1.AppendText(inputLabel);
            state = 0;
            label1.Text = "ACCOUNT NUMBER:";
            label1.Visible = true;
            textBox1.Visible = true;
            panel1.BackgroundImage = System.Drawing.Bitmap.FromFile("bgImage.jpg");
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
                    ac[acc].decrementBalance(5);
                    runMoneyAnimation();
                    enterStateSecond();
                    break;
                default:
                    break;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            switch (state)
            {
                case 2:
                    break;
                case 3:
                    ac[acc].decrementBalance(50);
                    runMoneyAnimation();
                    enterStateSecond();
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
                    ac[acc].decrementBalance(10);
                    runMoneyAnimation();
                    enterStateSecond();
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
                    ac[acc].decrementBalance(100);
                    runMoneyAnimation();
                    enterStateSecond();
                    break;
                default:
                    break;
            }
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
                    break;
                case 3:
                    ac[acc].decrementBalance(20);
                    runMoneyAnimation();
                    enterStateSecond();
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
                    runMoneyAnimation();
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

