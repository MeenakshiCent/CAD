using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
       private double firstNumber = 0;
       private string operation = "";
       private bool isOperationClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // for addition
        private void button1_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtNum1.Text,out double num1) && double.TryParse(txtNum2.Text , out double num2))
                {
                double result = num1 + num2;
                LblResult.Text = "Result:"+result.ToString();
            }
            else
            {
                LblResult.Text = "Please enter valid number";
            }
        }//Addition

        private void button2_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtNum1.Text,out double num1)&& double.TryParse(txtNum2.Text ,out double num2))
            {
                double result = num1 - num2;
                LblResult.Text = "Result:" + result.ToString();
            }
            else
            {
                LblResult.Text = " please enter valid numbers";
            }
        }//Subtraction


        private void Num1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out double num1) && double.TryParse(txtNum2.Text, out double num2))
            {
                double result = num1 * num2;
                LblResult.Text = "Result:" + result.ToString();
            }
            else
            {
                LblResult.Text = " please enter valid numbers";
            }
        }//multiplication

        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out double num1) && double.TryParse(txtNum2.Text, out double num2))
            {
                double result = num1 / num2;
                LblResult.Text = "Result:" + result.ToString();
            }
            else
            {
                LblResult.Text = " please enter valid numbers";
            }
        }//Division


        //Simple calculator
        private void NumberButton_click(object sender, EventArgs e) // for 0-9 numbers
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Clear display if starting fresh after an operation or display shows 0
                if (txtDisplay.Text == "0" || isOperationClicked)
                {
                    txtDisplay.Text = "";
                    isOperationClicked = false;
                }

                txtDisplay.Text += btn.Text;  // Append the digit clicked
            }
        }

        private void OperationButton(object sender, EventArgs e) // for +,-,*,/ for all these operation
        {
            if(double.TryParse(txtDisplay.Text , out firstNumber))
            {
                Button btn = sender as Button;
                operation = btn.Text;
                isOperationClicked = true;
                txtDisplay.Text = "";

            }
        }

        private void btnEq_Click(object sender, EventArgs e)  // for = operation
        {
            double secondNumber;
            double result;

            if (double.TryParse(txtDisplay.Text, out secondNumber))
            {
                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber == 0)
                        {
                            txtDisplay.Text = "Error";
                            return;
                        }
                        result = firstNumber / secondNumber;
                        break;
                    default:
                        return;
                }

                txtDisplay.Text = result.ToString();
                isOperationClicked = true;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)  // clear button
        {
            txtDisplay.Text = "0";
            firstNumber = 0;
            operation = "";
            isOperationClicked = false;
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                txtDisplay.Text = "0";
                isOperationClicked = false;
            }

            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }

        }
        //for Result display
        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

    }
}
