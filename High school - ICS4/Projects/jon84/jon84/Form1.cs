using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jon84
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            double sum = functionA(10);
            lblOut.Text = sum.ToString();
        }

        double functionA(double n)
        {
            if (n <= 1)
                return n;
            else
                return Math.Pow(2, n - 1) + functionA(n - 1);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            double sum = functionB(10);
            lblOut.Text = sum.ToString();
        }

        double functionB(double n)
        {
            if (n <= 1)
                return n * 4 - 3;
            else
                return n * 4 - 3 + functionB(n - 1);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            double sum = functionC(10);
            lblOut.Text = sum.ToString();
        }

        double functionC(double n)
        {
            if (n <= 1)
                return n;
            else
                return (1 / n) + functionC(n - 1);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            double sum = functionD(50);
            lblOut.Text = sum.ToString();
        }

        double functionD(double n)
        {
            if (n <= 1)
                return n;
            else if (n % 2 == 0)
            {
                return -1 / n + functionD(n - 1);
            }
            else //n%2 != 0
            {
                return 1 / n + functionD(n - 1);
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            double sum = functionE(5);
            lblOut.Text = sum.ToString();
        }

        double functionE(double n)
        {
            if (n <= 1)
                return 2 * n + 6;
            else
                return 2 * n + 6 + functionE(n - 1);
        }
    }
}
