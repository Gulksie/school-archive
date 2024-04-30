using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Michael Gulka, 9/14/17, job04
namespace job03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //delare vars
            double retail = 120.99;
            double wholesale = 90.0;
            double ans;

            //do the math
            ans = ((retail - wholesale) / wholesale) * 100;

            MessageBox.Show("The percentage markup is " + Math.Round(ans, 0) + "%");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
