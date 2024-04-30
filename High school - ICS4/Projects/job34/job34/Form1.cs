using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job34
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
            sb.Value = sb.Minimum;
            lblOut.Text = "";
        }

        private void sb_Scroll(object sender, ScrollEventArgs e)
        {
            string output = "Grade " + sb.Value + "\nYou should take";

            switch (sb.Value)
            {
                case 9: //grade 9
                    output += "BTT 1O1";
                    break;
                case 10: //grade 10
                    output += "ICS 2O1";
                    break;
                case 11: //grade 11
                    output += "ICS 3C1 or ICS 3U1";
                    break;
                case 12: //grade 12
                    output += "ICS 4C1 or ICS 4U1";
                    break;
            }

            lblOut.Text = output;
        }
    }
}
