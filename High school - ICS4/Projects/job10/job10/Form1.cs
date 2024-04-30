using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace job10
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
            int sales = Convert.ToInt32(Interaction.InputBox("Enter sales", "Sales"));

            double commision = 0;

            if (sales > 20000)
            {
                commision = sales * 0.5;
            }

            lblMain.Text = "Total sales: $" + sales + "\nCommission: $" + commision +
                "\nTotal salary: $" + (commision + sales);
        }
    }
}
