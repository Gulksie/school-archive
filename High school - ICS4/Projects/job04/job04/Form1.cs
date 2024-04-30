using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace job04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            double cost;
            while (true)
            {
                string tmp = Interaction.InputBox("Enter cost (DOUBLE)", "Cost");

                try
                {
                    cost = Convert.ToDouble(tmp);
                    break;
                }
                catch (FormatException)
                {
                    MessageBox.Show("INPUT NOT DOUBLE", "Error");
                    continue;
                }
            }

            double total = cost * 1.13;

            MessageBox.Show("Total cost is $" + Math.Round(total, 2) + "."); 
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
