using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace B_Teliki
{
    public partial class Calculator : Form
    {
        int a, b, result;
        string oper;
        bool gotResult = false;
        Player player1;
        
        public Calculator(Player player1)
        {
            InitializeComponent();
            this.player1 = player1;
        }

        //Updates text
        private void appendText(string i)
        {
            if (gotResult)
            {
                gotResult = false;
                txtboxShow.Text = String.Empty;
            }
            txtboxShow.Text += i;
        }

        //Checks for valid operator sequences.
        private void operatorClick(string oper)
        {
            if (txtboxShow.Text.Length > 0 && Regex.IsMatch(txtboxShow.Text.Last().ToString(), "[*+/-]"))
            {
                int textLength = txtboxShow.Text.Length;
                txtboxShow.Text = txtboxShow.Text.Substring(0, textLength - 1) + oper;
                this.oper = oper;
            }
            else if (!Regex.IsMatch(txtboxShow.Text, "[*+/]"))
            {
                appendText(oper);
            }
        }


        #region General Clicks
        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                //Gets a string, splits it and gets a, b, operator.
                string input = txtboxShow.Text;
                string aInp = String.Empty;
                string bInp = String.Empty;
                char sign = '+';
                bool gotA = false;
                for(int i = 0; i < input.Count(); i++)
                {
                    if(i==0 && input[i] == '-')
                    {
                        sign = '-';
                    }
                    else
                    {
                        if(Regex.IsMatch(input[i].ToString(), "[*+/-]")){
                            oper = input[i].ToString();
                            gotA = Regex.IsMatch(input[i].ToString(), "[*+/-]");
                            continue;
                        }
                        if (gotA)
                        {
                            bInp += input[i];
                        }
                        else
                        {
                            aInp += input[i];
                        }                        
                    }
                }
                a = Int32.Parse(aInp);
                a = sign == '+' ? a : (-1) * a; // a < 0
                b = Int32.Parse(bInp);
                //Finds the result.
                switch (oper)
                {
                    case ("+"):
                        result = a + b;

                        break;
                    case ("-"):
                        result = a - b;

                        break;
                    case ("*"):
                        result = a * b;
                        break;
                    case ("/"):
                        if (b != 0)
                        {
                            result = a / b;
                        }
                        else
                        {
                            MessageBox.Show("You can't divide by zero.");
                            txtboxShow.Text = String.Empty;
                        }
                        break;
                }
                txtboxShow.Text = result.ToString();
                gotResult = true;
                player1.CalculatorUsed++;

            }catch(Exception)
            {
                txtboxShow.Text = String.Empty;
                MessageBox.Show("Please give correct input.");

            }
        }        
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxShow.Clear();
            oper = null;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            int textLength = txtboxShow.Text.Length;
            if (textLength > 0)
            {
                txtboxShow.Text = txtboxShow.Text.Substring(0, textLength - 1);
            }
        }
        #endregion

        #region Num Clicks
        private void num1_Click(object sender, EventArgs e)
        {
            appendText("1");
        }

        private void num2_Click(object sender, EventArgs e)
        {
            appendText("2");
        }

        private void num3_Click(object sender, EventArgs e)
        {
            appendText("3");
        }

        private void num4_Click(object sender, EventArgs e)
        {
            appendText("4");
        }

        private void num5_Click(object sender, EventArgs e)
        {
            appendText("5");
        }

        private void num6_Click(object sender, EventArgs e)
        {
            appendText("6");
        }

        private void num7_Click(object sender, EventArgs e)
        {
            appendText("7");
        }

        private void num8_Click(object sender, EventArgs e)
        {
            appendText("8");
        }

        private void num9_Click(object sender, EventArgs e)
        {
            appendText("9");
        }
        private void num0_Click(object sender, EventArgs e)
        {
            appendText("0");
        }

        #endregion

        #region Oper Clicks
        private void btnDivision_Click(object sender, EventArgs e)
        {
            operatorClick("/");
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            operatorClick("*");
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            operatorClick("-");
        }

        private void addition_Click(object sender, EventArgs e)
        {
            operatorClick("+");
        }
        #endregion



    }


 }
    
    

