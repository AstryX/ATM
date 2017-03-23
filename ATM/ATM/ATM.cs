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
        public ATM(Account[] acMain)
        {
            ac = acMain;
            InitializeComponent();
            state = 0;
            acc = -1;
            inputLabel = "";
            accountAmount = 3;
            takenamount = 0;
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
                        inputLabel = "Wrong password!";
                        textBox1.Clear();
                        textBox1.AppendText(inputLabel);
                        state = 0;
                    }
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
                    label2.Text = ac[acc].getBalance().ToString();
                    break;
                case 3:
                    ac[acc].decrementBalance(20);
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
                    otherCashback tempCashWindow = new otherCashback(ac[acc]);
                    tempCashWindow.ShowDialog();
                    enterStateSecond();
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
    }
}

