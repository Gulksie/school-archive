//Michael Gulka, assign1a
//the purpose of this program is to ask students what their plans are for post secondary
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ICS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int postSecondary = 0;
            int twelvePlus = 0;
            int undecided = 0;

            for (int i = 0; i < 10; i++)
            {
                int choice;
                try //get choice and try to convert to int
                {
                    choice = Convert.ToInt32(Interaction.InputBox("Enter your plans for after grade 12\nPlease enter 1 for post secondary, 2 for grade 12+, or 3 for undecided.", "After grade 12"));
                }
                catch (FormatException) //choice is not an int, let them go again
                {
                    i--;
                    continue;
                }

                //check choice
                if (choice == 1)
                {
                    postSecondary++;
                }
                else if (choice == 2)
                {
                    twelvePlus++;
                }
                else if (choice == 3)
                {
                    undecided++;
                }
                else // choice is out of range, let them go again
                {
                    i--;
                    continue;
                }
            }

            lblMain.Text = "Survey Says:\nPost-Secondary    " + postSecondary + "\nGrade 12+    " + twelvePlus + "\nUndecided   " + undecided;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMain.Text = "";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
