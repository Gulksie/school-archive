using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace job15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int num = new Random().Next(1, 25);
            int guess = -1;
            int guesses = 0;
            bool done = false;

            do
            {
                guess = Convert.ToInt32(Interaction.InputBox("Guess number"));

                if (guess > 25 || guess < 1)
                {
                    MessageBox.Show("Out of range");
                }
                else if (guess > num)
                {
                    MessageBox.Show("Too high");
                }
                else if (guess < num)
                {
                    MessageBox.Show("Too low");
                }
                else
                {
                    MessageBox.Show("Correct!\nIt took " + guesses + " guesses");

                    DialogResult playAgain = MessageBox.Show("Want to play again?", 
                        "Play again?", MessageBoxButtons.YesNo);

                    switch (playAgain)
                    {
                        case DialogResult.Yes:
                            guesses = -1;
                            num = new Random().Next(1, 25);
                            break;
                        case DialogResult.No:
                            done = true;
                            break;
                        default:
                            done = true;
                            break;
                    }
                }
                guesses++;
            } while (!done);

            
        }
    }
}
