using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job27
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdoCake.Checked = false;
            rdoCookie.Checked = false;
            rdoCupcake.Checked = false;
            reset();
        }

        void reset()
        {
            picCake.Visible = false;
            picCookie.Visible = false;
            picCupcake.Visible = false;

            lblItem.Visible = false;
            lblItemTitle.Visible = false;
            lblPrice.Visible = false;
            lblPriceTitle.Visible = false;
        }

        void setLabelsVisible()
        {
            lblItem.Visible = true;
            lblItemTitle.Visible = true;
            lblPrice.Visible = true;
            lblPriceTitle.Visible = true;
        }

        private void rdoCupcake_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            picCupcake.Visible = true;
            setLabelsVisible();
            lblItem.Text = "Cupcake";

            lblPrice.Text = "$1.19";
        }

        private void rdoCookie_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            picCookie.Visible = true;
            setLabelsVisible();
            lblItem.Text = "Cookie";

            lblPrice.Text = "$0.75";
        }

        private void rdoCake_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            picCake.Visible = true;
            setLabelsVisible();
            lblItem.Text = "Cake";

            lblPrice.Text = "$2.50";
        }
    }
}
