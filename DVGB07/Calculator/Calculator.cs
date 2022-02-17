using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private string currentOperation = "";
        private string val1 = "";
        private string val2 = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void AddToEquation_Clicked(object sender, EventArgs args)
        {
            var btnPressed = sender as Button;
            lbl_calculation.Text += btnPressed.Text;
            if (currentOperation == "")
                val1 += btnPressed.Text;
            else
                val2 += btnPressed.Text;
        }

        private void Arithmetic_Clicked(object sender, EventArgs args)
        {
            var btnPressed = sender as Button;

            if (currentOperation != "" && val2 == "")
            {
                lbl_calculation.Text =
                    lbl_calculation.Text.Substring(0, lbl_calculation.Text.Length - 1);
            }

            lbl_calculation.Text += btnPressed.Text;

            if (currentOperation != "" && val2 != "")
            {
                UpdateResult();
            }

            currentOperation = btnPressed.Text;
        }

        private void UpdateResult()
        {
            if (val2 == "0" && currentOperation == @"/")
            {
                ShowError("Det går inte att dela med 0");
            }

            try
            {
                var result = DoCalculation();
                lbl_result.Text = result.ToString();
                val1 = result.ToString();
                val2 = "";
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
            if (int.TryParse(val1, out var leftVal) && int.TryParse(val2, out var rightValue))
            {
                switch (currentOperation)
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
            }
            else
            {
                throw new ArithmeticException("Number outside of bounds");
            }

            return result;
        }

        private void sum_clicked(object sender, EventArgs args)
        {
          UpdateResult();
          currentOperation = "";
        }

        private void clear(object sender, EventArgs args)
        {
            lbl_error.Visible = false;
            lbl_result.Text = "0";
            lbl_calculation.Text = "";
            currentOperation = "";
            val1 = "";
            val2 = "";
        }
    }
}
