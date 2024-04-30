using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace medianThingy
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
            //array items should be seperated by a space
            string[] dataStr = txtIn.Text.Split(' ');
            int[] data = new int[dataStr.Length];

            for (int i = 0; i < data.Length; i++)
            {
                try
                {
                    data[i] = Convert.ToInt32(dataStr[i]);
                }
                catch (FormatException)
                {
                    lblMain.Text = "Invalid input!";
                    return;
                }
            }

            lblMain.Text = txtIn.Text + '\n';
            
            //bubble sort
            bool flag = true;
            do
            {
                flag = false;
                for (int i = 0; i < data.Length-1; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        flag = true;
                        int tmp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = tmp;
                    }
                }
            } while (flag);

            foreach(int i in data) {
                lblMain.Text += i + " ";
            }

            lblMain.Text += '\n';

            double median;
            if (data.Length % 2 == 0) //even
            {
                int rightMedian = data.Length / 2;
                int leftMedian = rightMedian - 1;
                median = (data[leftMedian] + data[rightMedian]) / 2d;
            }
            else
            {
                median = data[data.Length / 2];
            }

            lblMain.Text += median.ToString();
        }
    }
}
