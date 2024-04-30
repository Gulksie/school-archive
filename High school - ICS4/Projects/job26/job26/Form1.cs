using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job26
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

        private void btnReset_Click(object sender, EventArgs e)
        {

            rdoLow.Checked = false;
            rdoMedium.Checked = false;
            rdoHigh.Checked = false;
            reset();
        }

        void reset()
        {
            picCorvette.Visible = false;
            picMustang.Visible = false;
            picPorsche.Visible = false;

            lblCorvette.Visible = false;
            lblMustang.Visible = false;
            lblPorshe.Visible = false;
        }

        private void rdoLow_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            picMustang.Visible = true;
            lblMustang.Visible = true;
        }

        private void rdoMedium_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            picCorvette.Visible = true;
            lblCorvette.Visible = true;
        }

        private void rdoHigh_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            picPorsche.Visible = true;
            lblPorshe.Visible = true;
        }
    }
}
