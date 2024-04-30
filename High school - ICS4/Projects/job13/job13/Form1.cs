using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace job13
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
            double total = 0;

            int marks = Convert.ToInt32(Interaction.InputBox("How many marks?"));

            for (int i = 0; i < marks; i++)
            {
                total += Convert.ToDouble(Interaction.InputBox("Enter mark"));
            }

            lblMain.Text = "Out of " + marks + " marks, your average is " + 
                (total / marks) + "%";
        }
    }
}
