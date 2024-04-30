using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job24
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

        private void rdoLunch2_CheckedChanged(object sender, EventArgs e)
        {
            lblOut.Text = "This should be called breakfast";
            lblOut.ForeColor = Color.Red;
        }

        private void rdoLunch3_CheckedChanged(object sender, EventArgs e)
        {
            lblOut.Text = "This is the best time to have lunch";
            lblOut.ForeColor = Color.Purple;
        }

        private void rdoLunch4_CheckedChanged(object sender, EventArgs e)
        {
            lblOut.Text = "I'm starving by now";
            lblOut.ForeColor = Color.Orange;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdoLunch2.Checked = false;
            rdoLunch3.Checked = false;
            rdoLunch4.Checked = false;

            lblOut.Text = "";
            lblOut.ForeColor = Color.Red;
        }
    }
}
