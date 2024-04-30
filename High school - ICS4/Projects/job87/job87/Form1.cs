using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ICS1
{
    public partial class Form1 : Form
    {
        string process;

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
            process = "";
            int total = generateFibonacci(35);

            lblMain.Text = process;
        }

        int generateFibonacci(int n, bool addToString=true) //n is the number of terms to generate
        {
            if (n <= 1)
            {
                if (addToString) {
                    process += "0 1 ";
                }
                return 1;
            }
            else
            {
                int previous = generateFibonacci(n - 1, addToString);
                int previous2 = generateFibonacci(n - 2, false);
                int total = previous + previous2;

                if (addToString)
                {
                    process += total + " ";
                }

                return total;
            }
        }
    }
}
