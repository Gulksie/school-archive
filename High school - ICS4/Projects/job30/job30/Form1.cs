using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job30
{
    public partial class Form1 : Form
    {
        double num1, num2;

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
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblOut.Text = "";
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(txtNum1.Text);
            }
            catch (FormatException)
            {
                num1 = 0;
            }
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                num2 = Convert.ToDouble(txtNum2.Text);
            }
            catch (FormatException)
            {
                num2 = 0;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblOut.Text = Convert.ToString(num1 + num2);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblOut.Text = Convert.ToString(num1 - num2);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblOut.Text = Convert.ToString(num1 * num2);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            lblOut.Text = Convert.ToString(num1 / num2);
        }
    }
}
