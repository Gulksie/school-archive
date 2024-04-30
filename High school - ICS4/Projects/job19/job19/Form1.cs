using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace job19
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
            int hours = 0;
            int mins = 0;
            int seconds = 0;
            while (true)
            {
                string time = Interaction.InputBox("Enter time as" + 
                    " hh:mm:ss or hit cancel to stop");
                if (time == "")
                {
                    break;
                }

                int tmpHours = Convert.ToInt32(time.Substring(0, 2));
                int tmpMin = Convert.ToInt32(time.Substring(3, 2));
                int tmpSec = Convert.ToInt32(time.Substring(6, 2));

                hours += tmpHours;
                mins += tmpMin;
                seconds += tmpSec;
            }

            //convert seconds to min
            mins += seconds / 60;
            seconds = seconds % 60;

            //same thing for min
            hours += mins / 60;
            mins = mins % 60;

            MessageBox.Show(hours + ":" + mins + ":" + seconds);
        }
    }
}
