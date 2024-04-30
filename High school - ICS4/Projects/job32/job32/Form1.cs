using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        void checkChanged()
        {
            string toSet = "";
            if (checkBox1.Checked)
            {
                toSet += "Check one\n";
            }
             if (checkBox2.Checked)
            {
                toSet += "Check two\n";
            }
             if (checkBox3.Checked)
            {
                toSet += "Check three";
            }

            label1.Text = toSet;
        }
    }
}
