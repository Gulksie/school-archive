using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace job18
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            string time = Interaction.InputBox("Enter time in format hh:mm");

            int hours = Convert.ToInt32(time.Substring(0, 2));
            string minutes = time.Substring(3);
            string suff = "AM";


            if (hours >= 24 || Convert.ToInt32(minutes) >= 60)
                return;

            if (hours > 12)
            {
                hours -= 12;
                suff = "PM";
            }

            MessageBox.Show("Time is " + hours + ":" + minutes + " " + suff);
        }
    }
}
