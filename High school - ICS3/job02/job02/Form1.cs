using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*Michael Gulka, 9/8/17, job02
 This program uses command buttons and numeric varibles
to calculate the cost of puchased at the deli*/

namespace WindowsFormsApplication1
{
    public partial class atTheDeli : Form
    {
        public atTheDeli()
        {
            InitializeComponent();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close(); //close the program
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //declare vars
            double numberOfKilos = 2.5;
            double unitPrice = 2.99;

            //calculate total
            double totalPrice = numberOfKilos * unitPrice;

            //Show the total
            MessageBox.Show("Your total cost is $" + Math.Round(totalPrice, 2).ToString() + ".");
        }
    }
}
