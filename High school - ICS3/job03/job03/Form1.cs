using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Michael Gulka, 9/14/17, job03
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
            double radius = 4.2;
            double ans;

            //do the math
            ans = (4.0/3.0) * Math.PI * (radius * radius * radius);

            MessageBox.Show("The volume of the Sphere is " + Math.Round(ans, 1) + " sq cm");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
