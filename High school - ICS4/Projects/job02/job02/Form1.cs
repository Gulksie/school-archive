//wow this is real boring
//Michael gulka
//This program uses buttons to calculate the price of Black Forest Ham purchased at the deli

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job02
{
    public partial class frmDeli : Form
    {
        public frmDeli()
        {
            InitializeComponent();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //stop
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //vars
            int kilos = 5;
            double price = 77.99;

            double total = kilos * price;

            MessageBox.Show("It cost " + total + " moneys");
        }
    }
}
