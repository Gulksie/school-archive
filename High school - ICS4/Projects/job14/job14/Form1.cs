using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace job14
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
            int total = 0;
            int entered = 0;

            do
            {
                total += Convert.ToInt32(Interaction.InputBox("Enter a number"));
                entered++;
            } while (total < 50);

            MessageBox.Show("Total = " + total + "\nEntered = " + entered);
        }
    }
}
