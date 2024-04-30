using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job22a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            double mark1 = Convert.ToDouble(txtFirstMark.Text);
            double mark2 = Convert.ToDouble(txtSecondMark.Text);

            lblOut.Text = Convert.ToString(Math.Round((mark1 + mark2) / 2, 2));
        }
    }
}
