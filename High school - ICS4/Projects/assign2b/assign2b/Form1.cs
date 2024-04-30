//Michael Gulka, ICS 4U1
//the purpose of this program is to calculate the total cost of a pizza order
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace assign2b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void calcPrice(object sender, EventArgs e)
        {
            double price = 0;

            //pizza size
            if (rdoReg.Checked)
                price += 12;

            else // large is checked
                price += 17;

            //toppings, $1.25 each
            if (chkMushrooms.Checked)
                price += 1.25;
            if (chkPeppers.Checked)
                price += 1.25;
            if (chkPepperoni.Checked)
                price += 1.25;
            if (chkOnions.Checked)
                price += 1.25;

            price *= 1.13; //tax

            //round the price to 2 digits and display it
            lblPrice.Text = "$" + Math.Round(price, 2);
        }
    }
}
