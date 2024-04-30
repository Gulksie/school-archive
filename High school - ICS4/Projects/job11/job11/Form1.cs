using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace job11
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMain.Text = "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int grade = Convert.ToInt32(Interaction.InputBox("Enter Gade", "Grade"));

            string toPut = "Your grade is: ";

            if (grade >= 80)
            {
                toPut += "A";
            }
            else if (grade >= 70)
            {
                toPut += "B";
            }
            else if (grade >= 60)
            {
                toPut += "C";
            }
            else if (grade >= 50)
            {
                toPut += "D";
            }
            else
            {
                toPut += "Fail";
            }

            lblMain.Text = toPut;
        }
    }
}
