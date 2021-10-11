using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        private string _input = string.Empty;            //This string stores the user input
        private string _lastResult = string.Empty;       //This string stores the last operation result
        private string _firstOperand = string.Empty;     //This string stores the first operand
        private string _secondOperand = string.Empty;    //This string stores the second operand
        private char _operation;                         //This char stores the operation type
        private double _result = 0.0;                    //This double respresents the operation result

        public Form1()
        {
            InitializeComponent();
        }

        //1 button (or 1 key) handler
        private void One_MouseClick(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            _input += "1";
            this.textBox1.Text += _input;
            this._lastResult = string.Empty;
        }

        //2 button (or 2 key) handler
        private void Two_MouseClick(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            _input += "2";
            this.textBox1.Text += _input;
            this._lastResult = string.Empty;
        }

        //3 button (or 3 key) handler
        private void Three_MouseClick(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            _input += "3";
            this.textBox1.Text += _input;
            this._lastResult = string.Empty;
        }

        //4 button (or 4 key) handler
        private void Four_MouseClick(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            _input += "4";
            this.textBox1.Text += _input;
            this._lastResult = string.Empty;
        }

        //5 button (or 5 key) handler
        private void Five_MouseClick(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            _input += "5";
            this.textBox1.Text += _input;
            this._lastResult = string.Empty;
        }

        //6 button (or 6 key) handler
        private void Six_MouseClick(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            _input += "6";
            this.textBox1.Text += _input;
            this._lastResult = string.Empty;
        }

        //7 button (or 7 key) handler
        private void Seven_MouseClick(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            _input += "7";
            this.textBox1.Text += _input;
            this._lastResult = string.Empty;
        }

        //8 button (or 8 key) handler
        private void Eight_MouseClick(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            _input += "8";
            this.textBox1.Text += _input;
            this._lastResult = string.Empty;
        }

        //9 button (or 9 key) handler
        private void Nine_MouseClick(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            _input += "9";
            this.textBox1.Text += _input;
            this._lastResult = string.Empty;
        }

        //0 button (or 0 key) handler
        private void Zero_MouseClick(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            _input += "0";
            this.textBox1.Text += _input;
            this._lastResult = string.Empty;
        }

        //Decimal button (or dot/comma key) handler
        private void Dot_MouseClick(object sender, EventArgs e)
        {
            if (!_input.Contains(','))
            {
                this.textBox1.Text = "";
                _input += ",";
                this.textBox1.Text += _input;
            }

        }

        //Clear button (or C key) handler
        private void Clear_MouseClick(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this._input = string.Empty;
            this._firstOperand = string.Empty;
            this._secondOperand = string.Empty;
            this._lastResult = string.Empty;
        }

        //Add button (or add key) handler
        private void Addition_MouseClick(object sender, EventArgs e)
        {
            if (_lastResult == string.Empty)
            {
                _firstOperand = _input;
                _operation = '+';
                _input = string.Empty;
            }
            else
            {
                _firstOperand = _lastResult;
                _operation = '+';
                _input = string.Empty;
            }

        }

        //Subtract button (or subtract key) handler
        private void Subtraction_MouseClick(object sender, EventArgs e)
        {
            if (_input!="")
            {
                _firstOperand = _input;
                _operation = '-';
                _input = string.Empty;
            }
            else
            {
                if (_lastResult != string.Empty)
                {
                    _firstOperand = _lastResult;
                    _operation = '-';
                    _input = string.Empty;
                }
                else
                {
                    this.textBox1.Text = "";
                    _input += "-";
                    this.textBox1.Text += _input;
                }

            }

        }

        //Multiply button (or multiply key) handler
        private void Multiplication_MouseClick(object sender, EventArgs e)
        {
            if (_lastResult == string.Empty)
            {
                _firstOperand = _input;
                _operation = '*';
                _input = string.Empty;
            }
            else
            {
                _firstOperand = _lastResult;
                _operation = '*';
                _input = string.Empty;
            }

        }

        //Divide button (or divide key) handler
        private void Division_MouseClick(object sender, EventArgs e)
        {
            if (_lastResult == string.Empty)
            {
                _firstOperand = _input;
                _operation = '/';
                _input = string.Empty;
            }
            else
            {
                _firstOperand = _lastResult;
                _operation = '/';
                _input = string.Empty;
            }

        }

        //Equal button (or enter key) handler
        private void Equal_MouseClick(object sender, EventArgs e)
        {
            _secondOperand = _input;


            double num1, num2;

            if (double.TryParse(_firstOperand, out num1) && double.TryParse(_secondOperand, out num2))
            {
                if (_operation == '+')
                {
                    _result = num1 + num2;
                    textBox1.Text = _result.ToString();
                }
                else if (_operation == '-')
                {
                    _result = num1 - num2;
                    textBox1.Text = _result.ToString();
                }
                else if (_operation == '*')
                {
                    _result = num1 * num2;
                    textBox1.Text = _result.ToString();
                }
                else if (_operation == '/')
                {
                    if (num2 != 0)
                    {
                        _result = num1 / num2;
                        textBox1.Text = _result.ToString();
                    }
                    else
                    {
                        textBox1.Text = "Error";
                    }
                }
                _input = "";
                _lastResult = _result.ToString();
            }
           
        }

        //This method is called when a key is released
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {           
            switch (e.KeyCode)
            {
                //Equal key
                case Keys.Enter:
                    Equal_MouseClick(sender, e);
                    break;
                //Number 1 key
                case Keys.D1:
                    One_MouseClick(sender, e);
                    break;
                case Keys.NumPad1:
                    One_MouseClick(sender, e);
                    break;
                //Number 2 key
                case Keys.D2:
                    Two_MouseClick(sender, e);
                    break;
                case Keys.NumPad2:
                    Two_MouseClick(sender, e);
                    break;
                //Number 3 key
                case Keys.D3:
                    Three_MouseClick(sender, e);
                    break;
                case Keys.NumPad3:
                    Three_MouseClick(sender, e);
                    break;
                //Number 4 key
                case Keys.D4:
                    Four_MouseClick(sender, e);
                    break;
                case Keys.NumPad4:
                    Four_MouseClick(sender, e);
                    break;
                //Number 5 key
                case Keys.D5:
                    Five_MouseClick(sender, e);
                    break;
                case Keys.NumPad5:
                    Five_MouseClick(sender, e);
                    break;
                //Number 6 key
                case Keys.D6:
                    Six_MouseClick(sender, e);
                    break;
                case Keys.NumPad6:
                    Six_MouseClick(sender, e);
                    break;
                //Number 7 key
                case Keys.D7:
                    Seven_MouseClick(sender, e);
                    break;
                case Keys.NumPad7 :
                    Seven_MouseClick(sender, e);
                    break;
                //Number 8 key
                case Keys.D8:
                    Eight_MouseClick(sender, e);
                    break;
                case Keys.NumPad8:
                    Eight_MouseClick(sender, e);
                    break;
                //Number 9 key
                case Keys.D9:
                    Nine_MouseClick(sender, e);
                    break;
                case Keys.NumPad9:
                    Nine_MouseClick(sender, e);
                    break;
                //Number 0 key
                case Keys.D0:
                    Zero_MouseClick(sender, e);
                    break;
                case Keys.NumPad0:
                    Zero_MouseClick(sender, e);
                    break;
                //Dot key
                case Keys.Decimal:
                    Dot_MouseClick(sender, e);
                    break;
                case Keys.Oemcomma:
                    Dot_MouseClick(sender, e);
                    break;
                case Keys.OemPeriod:
                    Dot_MouseClick(sender, e);
                    break;
                //Addition key
                case Keys.Oemplus:
                    Addition_MouseClick(sender, e);
                    break;
                case Keys.Add:
                    Addition_MouseClick(sender, e);
                    break;
                //Subtraction key
                case Keys.OemMinus:
                    Subtraction_MouseClick(sender, e);
                    break;
                case Keys.Subtract:
                    Subtraction_MouseClick(sender, e);
                    break;
                //Multiplication
                case Keys.Multiply:
                    Multiplication_MouseClick(sender, e);
                    break;
                //Division key
                case Keys.Divide:
                    Division_MouseClick(sender, e);
                    break;
                //Clear key
                case Keys.C:
                    Clear_MouseClick(sender, e);
                    break;
                case Keys.Clear:
                    Clear_MouseClick(sender, e);
                    break;
                default:
                    break;
            }
        }
    }
}
