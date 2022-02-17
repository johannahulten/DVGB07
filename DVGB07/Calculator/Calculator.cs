using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private string _currentOperation = "";
        private string _memoryOperation = "";
        private string _memoryVal = "";
        private string _val1 = "";
        private string _val2 = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void AddToEquation_Clicked(object sender, EventArgs args)
        {
            var btnPressed = sender as Button;
            lbl_calculation.Text += btnPressed.Text;
            if (_currentOperation == "")
                _val1 += btnPressed.Text;
            else
                _val2 += btnPressed.Text;
        }

        private void Arithmetic_Clicked(object sender, EventArgs args)
        {
            var btnPressed = sender as Button;

            if (_currentOperation != "" && _val2 == "")
                lbl_calculation.Text =
                    lbl_calculation.Text.Substring(0, lbl_calculation.Text.Length - 1);

            lbl_calculation.Text += btnPressed.Text;

            if (_currentOperation != "" && _val2 != "") UpdateResult();

            _currentOperation = btnPressed.Text;
        }

        private void UpdateResult()
        {
            if (_val2 == "0" && _currentOperation == @"/") ShowError("Det går inte att dela med 0");

            _memoryVal = _val2;
            _memoryOperation = _currentOperation;

            try
            {
                var result = DoCalculation();
                lbl_result.Text = result.ToString();
                _val1 = result.ToString();
                _val2 = "";
            }
            catch (Exception)
            {
                ShowError("Talet blev så stort att programet inte kan räkna med det");
            }
        }

        private void ShowError(string msg)
        {
            lbl_error.Visible = true;
            lbl_result.Text = "Något gick fel";
            lbl_error.Text = msg;
        }

        private int DoCalculation()
        {
            var result = 0;
            if (int.TryParse(_val1, out var leftVal) && int.TryParse(_val2, out var rightValue))
                switch (_currentOperation)
                {
                    case "+":
                    {
                        result = leftVal + rightValue;
                        break;
                    }
                    case "-":
                    {
                        result = leftVal - rightValue;
                        break;
                    }
                    case "*":
                    {
                        result = leftVal * rightValue;
                        break;
                    }
                    case "/":
                    {
                        result = leftVal / rightValue;
                        break;
                    }
                }
            else
                throw new ArithmeticException("Number outside of bounds");

            return result;
        }

        private void Sum_clicked(object sender, EventArgs args)
        {
            if (_currentOperation == "")
            {
                _currentOperation = _memoryOperation;
                _val2 = _memoryVal;
            }

            UpdateResult();
            _currentOperation = "";
        }

        private void Clear(object sender, EventArgs args)
        {
            lbl_error.Visible = false;
            lbl_result.Text = "0";
            lbl_calculation.Text = "";
            _currentOperation = "";
            _val1 = "";
            _val2 = "";
        }
    }
}