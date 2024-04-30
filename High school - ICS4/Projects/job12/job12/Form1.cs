using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace job12
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
            int num1 = Convert.ToInt32(Interaction.InputBox("Enter start number"));
            int num2 = Convert.ToInt32(Interaction.InputBox("Enter end number"));

            lblMain.Text = "";

            for (; num1 <= num2; num1++)
            {
                lblMain.Text += num1 + " ";
            }
        }
    }
}
