using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblOut.Text = "THE NAMES\n";
            string[] names = {"Mickey", "Minnie", "Goofy", "Donald", "Pluto"};

            for (int i = 0; i < names.Length; i++ )
            {
                lblOut.Text += names[i] + "\n";
            }
        }
    }
}
