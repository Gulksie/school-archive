using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace job16
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
            int num = Convert.ToInt32(Interaction.InputBox("Enter a number"));
            int factorial = num;

            for (int i = num - 1; i > 0; i--)
            {
                factorial *= i;
            }

            MessageBox.Show("Number = " + num + "\nFactorial = " + factorial);
        }
    }
}
