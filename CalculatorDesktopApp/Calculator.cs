namespace CalculatorDesktopApp
{
    public partial class Calculator : Form
    {
        List<int> TwoToNine = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9 };
        List<char> OperandSymbols = new List<char>() { '+', '-', '/', '*' };
        int EquationTotal;
        int rightNum;
        string previousOperand;
        bool operandPressed = false;
        bool errorResult = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operandPressed)
            {
                InputNum.Text = "";
                operandPressed = false;
            }               
            InputNum.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operandPressed)
            {
                InputNum.Text = "";
                operandPressed = false;
            }
            InputNum.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operandPressed)
            {
                InputNum.Text = "";
                operandPressed = false;
            }
            InputNum.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operandPressed)
            {
                InputNum.Text = "";
                operandPressed = false;
            }
            InputNum.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operandPressed)
            {
                InputNum.Text = "";
                operandPressed = false;
            }
            InputNum.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operandPressed)
            {
                InputNum.Text = "";
                operandPressed = false;
            }
            InputNum.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (operandPressed)
            {
                InputNum.Text = "";
                operandPressed = false;
            }
            InputNum.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operandPressed)
            {
                InputNum.Text = "";
                operandPressed = false;
            }
            InputNum.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operandPressed)
            {
                InputNum.Text = "";
                operandPressed = false;
            }
            InputNum.Text += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (operandPressed)
            {
                InputNum.Text = "";
                operandPressed = false;
            }
            InputNum.Text += buttonCLR.Text;
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            OperandDisplay.Text = "";
            OperandDisplay.Text = Addition.Text;
            operandPressed = true;

            //add num to equation display
            if (WholeEquation.Text.Equals("Equation") && String.IsNullOrEmpty(InputNum.Text)) //no num in inputnum or whole equation
            {
                WholeEquation.Text = "0";
                WholeEquation.Text += OperandDisplay.Text;
                EquationTotal = 0;
            }
            else if (WholeEquation.Text.Equals("Equation") && !String.IsNullOrEmpty(InputNum.Text)) //no num in whole equation and num in inputnum
            {
                WholeEquation.Text = "";
                WholeEquation.Text += InputNum.Text;

                EquationTotal += int.Parse(InputNum.Text);
                WholeEquation.Text = "";
                WholeEquation.Text = EquationTotal.ToString();
            }
            else //num in whole equation and inputnum
            {
                WholeEquation.Text += InputNum.Text;

                EquationTotal += int.Parse(InputNum.Text);
                WholeEquation.Text = "";
                WholeEquation.Text = EquationTotal.ToString();
            }

            //add operand to equation display
            if (!OperandSymbols.Contains(WholeEquation.Text[WholeEquation.Text.Length - 1]))
            {
                WholeEquation.Text += OperandDisplay.Text;            
            }
            else if (OperandSymbols.Contains(WholeEquation.Text[WholeEquation.Text.Length - 1]))
            {
                string newEquation = WholeEquation.Text.Remove(WholeEquation.Text.Length - 1);
                WholeEquation.Text = newEquation;
                WholeEquation.Text += OperandDisplay.Text;
            }

            previousOperand = OperandDisplay.Text;

            WholeEquation.Visible = true;

            InputNum.Text = EquationTotal.ToString();
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            OperandDisplay.Text = "";
            OperandDisplay.Text = Subtract.Text;
            operandPressed = true;

            //add num to equation display
            if (WholeEquation.Text.Equals("Equation") && String.IsNullOrEmpty(InputNum.Text)) //no num in inputnum or whole equation
            {
                WholeEquation.Text = "0";
                WholeEquation.Text += OperandDisplay.Text;
                EquationTotal = 0;
            }
            else if (WholeEquation.Text.Equals("Equation") && !String.IsNullOrEmpty(InputNum.Text)) //no num in whole equation and num in inputnum
            {
                WholeEquation.Text = "";
                WholeEquation.Text += InputNum.Text;

                EquationTotal -= int.Parse(InputNum.Text);
                WholeEquation.Text = "";
                WholeEquation.Text = EquationTotal.ToString();
            }
            else //num in whole equation and inputnum
            {
                WholeEquation.Text += InputNum.Text;

                EquationTotal -= int.Parse(InputNum.Text);
                WholeEquation.Text = "";
                WholeEquation.Text = EquationTotal.ToString();
            }

            //add operand to equation display
            if (!OperandSymbols.Contains(WholeEquation.Text[WholeEquation.Text.Length - 1]))
            {
                WholeEquation.Text += OperandDisplay.Text;
            }
            else if (OperandSymbols.Contains(WholeEquation.Text[WholeEquation.Text.Length - 1]))
            {
                string newEquation = WholeEquation.Text.Remove(WholeEquation.Text.Length - 1);
                WholeEquation.Text = newEquation;
                WholeEquation.Text += OperandDisplay.Text;
            }

            previousOperand = OperandDisplay.Text;

            WholeEquation.Visible = true;

            InputNum.Text = EquationTotal.ToString();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            OperandDisplay.Text = "";
            OperandDisplay.Text = Multiply.Text;
            operandPressed = true;

            //add num to equation display
            if (WholeEquation.Text.Equals("Equation") && String.IsNullOrEmpty(InputNum.Text)) //no num in inputnum or whole equation
            {
                WholeEquation.Text = "0";
                WholeEquation.Text += OperandDisplay.Text;
                EquationTotal = 0;
            }
            else if (WholeEquation.Text.Equals("Equation") && !String.IsNullOrEmpty(InputNum.Text)) //no num in whole equation and num in inputnum
            {
                WholeEquation.Text = "";
                WholeEquation.Text += InputNum.Text;

                EquationTotal *= int.Parse(InputNum.Text);
                WholeEquation.Text = "";
                WholeEquation.Text = EquationTotal.ToString();
            }
            else //num in whole equation and inputnum
            {
                WholeEquation.Text += InputNum.Text;

                EquationTotal *= int.Parse(InputNum.Text);
                WholeEquation.Text = "";
                WholeEquation.Text = EquationTotal.ToString();
            }

            //add operand to equation display
            if (!OperandSymbols.Contains(WholeEquation.Text[WholeEquation.Text.Length - 1]))
            {
                WholeEquation.Text += OperandDisplay.Text;
            }
            else if (OperandSymbols.Contains(WholeEquation.Text[WholeEquation.Text.Length - 1]))
            {
                string newEquation = WholeEquation.Text.Remove(WholeEquation.Text.Length - 1);
                WholeEquation.Text = newEquation;
                WholeEquation.Text += OperandDisplay.Text;
            }

            previousOperand = OperandDisplay.Text;

            WholeEquation.Visible = true;

            InputNum.Text = EquationTotal.ToString();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            OperandDisplay.Text = "";
            OperandDisplay.Text = Division.Text;
            operandPressed = true;

            //add num to equation display
            if (WholeEquation.Text.Equals("Equation") && String.IsNullOrEmpty(InputNum.Text)) //no num in inputnum or whole equation
            {
                WholeEquation.Text = "0";
                WholeEquation.Text += OperandDisplay.Text;
                EquationTotal = 0;
            }
            else if (WholeEquation.Text.Equals("Equation") && !String.IsNullOrEmpty(InputNum.Text)) //no num in whole equation and num in inputnum
            {
                WholeEquation.Text = "";
                WholeEquation.Text += InputNum.Text;

                if (InputNum.Text != "0")
                {
                    EquationTotal /= int.Parse(InputNum.Text);
                    WholeEquation.Text = "";
                    WholeEquation.Text = EquationTotal.ToString();
                }
                else
                {
                    WholeEquation.Text = "";
                    InputNum.Text = "Error";
                }                   
            }
            else //num in whole equation and inputnum
            {
                WholeEquation.Text += InputNum.Text;

                if (InputNum.Text != "0")
                {
                    EquationTotal /= int.Parse(InputNum.Text);
                    WholeEquation.Text = "";
                    WholeEquation.Text = EquationTotal.ToString();
                }
                else
                {
                    WholeEquation.Text = "";
                    InputNum.Text = "Error";
                }
            }

            //add operand to equation display
            if (!OperandSymbols.Contains(WholeEquation.Text[WholeEquation.Text.Length - 1]))
            {
                WholeEquation.Text += OperandDisplay.Text;
            }
            else if (OperandSymbols.Contains(WholeEquation.Text[WholeEquation.Text.Length - 1]))
            {
                string newEquation = WholeEquation.Text.Remove(WholeEquation.Text.Length - 1);
                WholeEquation.Text = newEquation;
                WholeEquation.Text += OperandDisplay.Text;
            }

            previousOperand = OperandDisplay.Text;

            WholeEquation.Visible = true;

            InputNum.Text = EquationTotal.ToString();
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            WholeEquation.Text = "";          

            switch (previousOperand)
            {
                case "+":
                    EquationTotal += int.Parse(InputNum.Text);
                    WholeEquation.Text = "";
                    WholeEquation.Text = EquationTotal.ToString();
                    break;
                case "-":
                    EquationTotal -= int.Parse(InputNum.Text);
                    WholeEquation.Text = "";
                    WholeEquation.Text = EquationTotal.ToString();
                    break;
                case "*":
                    EquationTotal *= int.Parse(InputNum.Text);
                    WholeEquation.Text = "";
                    WholeEquation.Text = EquationTotal.ToString();
                    break;
                case "/":
                    EquationTotal /= int.Parse(InputNum.Text);
                    WholeEquation.Text = "";
                    WholeEquation.Text = EquationTotal.ToString();
                    break;
                default:
                    EquationTotal = int.Parse(InputNum.Text);
                    WholeEquation.Text = "";
                    WholeEquation.Text = EquationTotal.ToString();
                    break;
            }

            WholeEquation.Text += previousOperand;

            rightNum = int.Parse(InputNum.Text);
            WholeEquation.Text += rightNum;

            WholeEquation.Visible = true;
        }

        private void buttonDEC_Click(object sender, EventArgs e)
        {
            EquationTotal = 0;
            WholeEquation.Text = "";

            foreach (int n in TwoToNine)
            {
                if (InputNum.Text.Contains(n.ToString()))
                {
                    errorResult = true;
                }                 
            }

            if (!errorResult)
            {
                string binNum = InputNum.Text;
                int num = Convert.ToInt32(binNum, 2);
                WholeEquation.Visible = true;
                WholeEquation.Text = num.ToString();
            }
            else
            {
                WholeEquation.Visible = true;
                WholeEquation.Text = "Error";
            }
        }

        private void buttonBIN_Click(object sender, EventArgs e)
        {
            EquationTotal = 0;
            WholeEquation.Text = "";

            string binNum = "";
            int numToConvert = int.Parse(InputNum.Text);
            int remainder;

            while (numToConvert > 0)
            {
                remainder = numToConvert % 2;
                numToConvert /= 2;
                binNum = remainder.ToString() + binNum;
            }

            WholeEquation.Visible = true;
            WholeEquation.Text = binNum;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WholeEquation.Text = "Equation";
            WholeEquation.Visible = false;
            OperandDisplay.Text = "";
            InputNum.Text = "";
            EquationTotal = 0;
            previousOperand = "";
            errorResult = false;
        }      
    }
}