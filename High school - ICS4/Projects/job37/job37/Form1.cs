using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace job37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMain.Text = "";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int[] marks = new int[4];

            for (int i = 0; i < 4; i++)
            {
                marks[i] = Convert.ToInt32(Interaction.InputBox("Enter Mark"));
            }

            double average = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                lblMain.Text += (i + 1) + ".    " + marks[i] + "\n";
                average += marks[i];
            }

            average /= 4;

            lblMain.Text += "Average    " + average;
        }
    }
}
