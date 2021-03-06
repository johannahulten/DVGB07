using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        private readonly List<int> _guesses = new List<int>();
        private readonly TextBox[] _guessBoxes;
        private int _iterations;
        private int[] _results = new int[3];

        public Form1()
        {
            InitializeComponent();
           
            _guessBoxes = new[] { txb_nbr_1, txb_nbr_2, txb_nbr_3, txb_nbr_4, txb_nbr_5, txb_nbr_6, tbx_nbr_7 };
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            pan_input.Enabled = false;
            pan_result.Visible = false;
            RunGames();

            UpdateWindow(_results[0], _results[1], _results[2]);
        }

        private void RunGames()
        {
            var nbrOf5Correct = 0;
            var nbrOf6Correct = 0;
            var nbrOf7Correct = 0;
            var random = new Random();

            for (var i = 0; i < _iterations; i++)
            {
                var row = new List<int>();

                do
                {
                    var generated = random.Next(1, 36);

                    if (!row.Contains(generated))
                        row.Add(generated);

                } while (row.Count < 7);

                var nbrCorrect = row.Intersect(_guesses);
                switch (nbrCorrect.Count())
                {
                    case 5:
                        nbrOf5Correct++;
                        break;
                    case 6:
                        nbrOf6Correct++;
                        break;
                    case 7:
                        nbrOf7Correct++;
                        break;
                }
                
            }

            _results = new[] { nbrOf5Correct, nbrOf6Correct, nbrOf7Correct };

        }

        private void UpdateWindow(int nbrOf5Correct, int nbrOf6Correct, int nbrOf7Correct)
        {
            pan_result.Visible = true;
            pan_input.Enabled = true;

            lbl_5_correct.Text = nbrOf5Correct.ToString();
            lbl_6_correct.Text = nbrOf6Correct.ToString();
            lbl_7_correct.Text = nbrOf7Correct.ToString();
        }

        private void Guess_Changed(object sender, EventArgs e)
        {
            lbl_error_guess.Visible = false;
            _guesses.Clear();
            DisableStartButton();
            foreach (var guessBox in _guessBoxes)
            {
                if(guessBox.Text != "")
                    HandleGuess(guessBox.Text);
            }

            UpdateStartButton();
        }

        private void DisableStartButton()
        {
            start_btn.Enabled = false;
        }

        private void UpdateStartButton()
        {
            if (_guesses.Count == 7 && _iterations > 0)
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

        private void iterations_Changed(object sender, EventArgs args)
        {
            lbl_error_iterations.Visible = false;
            _iterations = 0;
            DisableStartButton();

            if (int.TryParse(txb_iterations.Text, out var nbrOfIterations))
            {
                if (nbrOfIterations <= 0)
                    ShowIterationError("Antalet dragningar måste vara ett positivt heltal, mindre än " + int.MaxValue);
                else
                {
                    _iterations = nbrOfIterations;
                    UpdateStartButton();
                }
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
