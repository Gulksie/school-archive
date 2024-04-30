using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblBox1.Text = "";
            lblBox2.Text = "";
        }

        private void btnAF_Click(object sender, EventArgs e)
        {
            lblBox1.Text = "Your last name starts with the letters A - F";
            lblBox2.Text = "Please see Mr. Macaluso";
        }

        private void btnGN_Click(object sender, EventArgs e)
        {
            lblBox1.Text = "Your last name starts with the letters G - N";
            lblBox2.Text = "Please see Mr. Valeri";
        }

        private void btnOZ_Click(object sender, EventArgs e)
        {
            lblBox1.Text = "Your last name starts with the letters O - Z";
            lblBox2.Text = "Please see Mr. John";
        }

    }
}
