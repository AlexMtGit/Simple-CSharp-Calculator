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

        string input = string.Empty;            //This string stores the user input
        string firstOperand = string.Empty;     //This string stores the first operand
        string secondOperand = string.Empty;    //This string stores the second operand
        char operation;                         //This char stores the operation type
        double result = 0.0;                    //This double respresents the operation result

        public Form1()
        {
            InitializeComponent();
        }


        private void one_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!input.Contains('.'))
            {
                this.textBox1.Text = "";
                input += ".";
                this.textBox1.Text += input;
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.firstOperand = string.Empty;
            this.secondOperand = string.Empty;
        }

        private void addition_Click(object sender, EventArgs e)
        {
            firstOperand = input;
            operation = '+';
            input = string.Empty;
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            if (input!="")
            {
                firstOperand = input;
                operation = '-';
                input = string.Empty;
            }
            else
            {
                this.textBox1.Text = "";
                input += "-";
                this.textBox1.Text += input;
            }

        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            firstOperand = input;
            operation = '*';
            input = string.Empty;
        }

        private void division_Click(object sender, EventArgs e)
        {
            firstOperand = input;
            operation = '/';
            input = string.Empty;
        }

        private void equal_Click(object sender, EventArgs e)
        {

            secondOperand = input;


            double num1, num2;

            if (double.TryParse(firstOperand, out num1) && double.TryParse(secondOperand, out num2))
            {
                if (operation == '+')
                {
                    result = num1 + num2;
                    textBox1.Text = result.ToString();
                }
                else if (operation == '-')
                {
                    result = num1 - num2;
                    textBox1.Text = result.ToString();
                }
                else if (operation == '*')
                {
                    result = num1 * num2;
                    textBox1.Text = result.ToString();
                }
                else if (operation == '/')
                {
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        textBox1.Text = "Error";
                    }
                }
                input = "";
            }
           
        }
    }
}
