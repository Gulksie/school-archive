using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace culminating
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();

            lblRules.Text = @"Rules:
1. A word will be randomly chosen for you to guess
2. Each turn, you will try to guess a letter or the whole word.
3. You will type your guess into the textbox. If you type more than one charicter, it will be assumed you are guessing a word
4. On the easy difficulty, you will have 20 guesses
5. On the medium difficulty, you will have 10 guesses
6. On the hard difficulty, you will have 5 guesses";

        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            new Hangman(Hangman.difficulty.easy).Show();
            this.Hide();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            new Hangman(Hangman.difficulty.medium).Show();
            this.Hide();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            new Hangman(Hangman.difficulty.hard).Show();
            this.Hide();
        }
    }
}
