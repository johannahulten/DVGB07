using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        private List<int> _guesses = new List<int>();
        private TextBox[] _guessBoxes;
        private int iterations;

        public Form1()
        {
            InitializeComponent();
            _guessBoxes = new[] { txb_nbr_1, txb_nbr_2, txb_nbr_3, txb_nbr_4, txb_nbr_5, txb_nbr_6, tbx_nbr_7 };
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void guess_Changed(object sender, EventArgs e)
        {
            lbl_error_guess.Visible = false;
            _guesses.Clear();
            foreach (var guessBox in _guessBoxes)
            {
                if(guessBox.Text != "")
                    HandleGuess(guessBox.Text);
            }

            if (CanStartGame())
                start_btn.Enabled = true;
        }

        private void HandleGuess(string text)
        {
            if (short.TryParse(text, out var guess))
            {
                if (_guesses.Any(x => x == guess))
                {
                    ShowGuessError("Du har gissat på " + guess + " två gånger, bara en gång är tillåtet");
                }
                else if (guess <= 0 || guess > 35)
                {
                    ShowGuessError("Bara tal mellan 1 och 35 är tillåtna i lottoraden");
                }
                else
                {
                    _guesses.Add(guess);
                }
            }
            else 
                ShowGuessError("Bara tal mellan 1 och 35 är tilålltna i lottoraden, inga andra tecken");
        }

        private void ShowGuessError(string msg)
        {
            lbl_error_guess.Text = msg;
            lbl_error_guess.Visible = true;
        }

        private bool CanStartGame()
        {
            return _guesses.Count == 7 && iterations > 0;
        }

        private void iterations_Changed(object sender, EventArgs args)
        {
            lbl_error_iterations.Visible = false;

            if (int.TryParse(txb_iterations.Text, out var nbrOfIterations))
            {
                if (nbrOfIterations <= 0)
                    ShowIterationError("Antalet dragningar måste vara ett positivt heltal, mindre än " + int.MaxValue);
                else
                    iterations = nbrOfIterations;
            }
            else
            {
                ShowIterationError("Antalet dragningar måste vara ett positivt heltal, mindre än " + int.MaxValue);
            }
        }

        private void ShowIterationError(string msg)
        {
            lbl_error_iterations.Visible = true;
            lbl_error_iterations.Text = msg;
        }
    }
}
