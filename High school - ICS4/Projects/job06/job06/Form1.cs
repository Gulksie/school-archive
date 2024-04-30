using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAF_Click(object sender, EventArgs e)
        {
            lblVP.Text = "Your vice principal is Mr. Macaluso";
        }

        private void btnGN_Click(object sender, EventArgs e)
        {
            lblVP.Text = "Your vice principal is Mr. Valeri";
        }

        private void btnOZ_Click(object sender, EventArgs e)
        {
            lblVP.Text = "Your vice principal is Mr. John";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblVP.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
