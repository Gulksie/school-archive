using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace job09
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
            int age = Convert.ToInt32(Interaction.InputBox("Enter age", "Age", "0"));

            int iceCream = Convert.ToInt32(Interaction.InputBox("Enter amount ice cream", "Ice Cream", "0"));

            if (age > 40 && iceCream >= 5)
            {
                MessageBox.Show("you get discount");
            }
            else
            {
                MessageBox.Show("no discount");
            }
        }
    }
}
