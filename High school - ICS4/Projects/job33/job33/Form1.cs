using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void updateCheck()
        {
            string selected = "";
            double total = 0;

            if (chkPrinter.Checked)
            {
                selected += "Printer\n";
                total += 110;
            }
            if (chkMonitor.Checked)
            {
                selected += "Monitor\n";
                total += 239;
            }
            if (chkRouter.Checked)
            {
                selected += "Router\n";
                total += 49;
            }
            if (chkSpeakers.Checked)
            {
                selected += "Speakers";
                total += 89;
            }

            if (rdoDelivery.Checked)
                total += 8.5;

            total *= 1.13;
            lblSelected.Text = selected;
            lblTotal.Text = "$" + Convert.ToString(Math.Round(total, 2));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkPrinter_CheckedChanged(object sender, EventArgs e)
        {
            updateCheck();
        }

        private void chkMonitor_CheckedChanged(object sender, EventArgs e)
        {
            updateCheck();
        }

        private void chkRouter_CheckedChanged(object sender, EventArgs e)
        {
            updateCheck();
        }

        private void chkSpeakers_CheckedChanged(object sender, EventArgs e)
        {
            updateCheck();
        }

        private void rdoDelivery_CheckedChanged(object sender, EventArgs e)
        {
            updateCheck();
        }

        private void rdoPickup_CheckedChanged(object sender, EventArgs e)
        {
            updateCheck();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "";
            lblSelected.Text = "";

            chkMonitor.Checked = false;
            chkPrinter.Checked = false;
            chkRouter.Checked = false;
            chkSpeakers.Checked = false;

            rdoDelivery.Checked = false;
            rdoPickup.Checked = true;
        }
    }
}
