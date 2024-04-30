using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sbYear_Scroll(object sender, ScrollEventArgs e)
        {
            lblYear.Text = Convert.ToString(sbYear.Value);

            if (sbYear.Value % 4 == 0 && sbMonth.Value == 2)
            {
                sbDay.Maximum = 29;
                sbDay.Value = 1;
            }
        }

        private void sbMonth_Scroll(object sender, ScrollEventArgs e)
        {
            switch (sbMonth.Value)
            {
                case 0:
                    lblMonth.Text = "January";
                    sbDay.Maximum = 31;
                    break;
                case 1:
                    lblMonth.Text = "February";
                    sbDay.Maximum = 28;
                    if (sbYear.Value % 4 == 0)
                    {
                        sbDay.Maximum = 29;
                        sbDay.Value = 0;
                    }
                    break;
                case 2:
                    lblMonth.Text = "March";
                    sbDay.Maximum = 31;
                    break;
                case 3:
                    lblMonth.Text = "April";
                    sbDay.Maximum = 30;
                    break;
                case 4:
                    lblMonth.Text = "May";
                    sbDay.Maximum = 31;
                    break;
                case 5:
                    lblMonth.Text = "June";
                    sbDay.Maximum = 30;
                    break;
                case 6:
                    lblMonth.Text = "July";
                    sbDay.Maximum = 31;
                    break;
                case 7:
                    lblMonth.Text = "August";
                    sbDay.Maximum = 31;
                    break;
                case 8:
                    lblMonth.Text = "September";
                    sbDay.Maximum = 31;
                    break;
                case 9:
                    lblMonth.Text = "October";
                    sbDay.Maximum = 31;
                    break;
                case 10:
                    lblMonth.Text = "November";
                    sbDay.Maximum = 30;
                    break;
                case 11:
                    lblMonth.Text = "December";
                    sbDay.Maximum = 31;
                    break;
            }
        }

        private void sbDay_Scroll(object sender, ScrollEventArgs e)
        {
            lblDay.Text = Convert.ToString(sbDay.Value);
        }
    }
}
