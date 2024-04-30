using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            lblOutColour.Text = "Red";
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblOutColour.Text = "Green";
        }

        private void rdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            lblOutColour.Text = "Yellow";
        }

        private void rdoXL_CheckedChanged(object sender, EventArgs e)
        {
            lblOutSize.Text = "XL";
        }

        private void rdoL_CheckedChanged(object sender, EventArgs e)
        {
            lblOutSize.Text = "L";
        }

        private void rdoM_CheckedChanged(object sender, EventArgs e)
        {
            lblOutSize.Text = "M";
        }

        private void rdoS_CheckedChanged(object sender, EventArgs e)
        {
            lblOutSize.Text = "S";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!rdoGreen.Checked && !rdoRed.Checked && !rdoYellow.Checked)
            {
                MessageBox.Show("You have not chosen a colour");
            }
            if (!rdoXL.Checked && !rdoL.Checked && !rdoM.Checked && !rdoS.Checked)
            {
                MessageBox.Show("You have not chosen a size");
            }
        }
    }
}
