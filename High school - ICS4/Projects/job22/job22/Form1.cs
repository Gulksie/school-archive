using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace job22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setLabelsVisible(false);
        }

        void setLabelsVisible(bool set)
        {
            lblTitle.Visible = set;

            lblYears.Visible = set;
            lblMonths.Visible = set;
            lblDays.Visible = set;
            lblHours.Visible = set;
            lblMinutes.Visible = set;
            lblSeconds.Visible = set;

            lblYearTitle.Visible = set;
            lblMonthsTitle.Visible = set;
            lblDaysTitle.Visible = set;
            lblHoursTitle.Visible = set;
            lblMinutesTitle.Visible = set;
            lblSecondsTitle.Visible = set;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            double years = Convert.ToDouble(Interaction.InputBox("How many years old are you?"));

            double months = years * 12;
            double days = years * 365;
            days += Convert.ToInt32(years/4);

            double hours = days * 24;
            double minutes = hours * 60;
            double seconds = minutes * 60;

            lblYears.Text = Convert.ToString(years);
            lblMonths.Text = Convert.ToString(months);
            lblDays.Text = Convert.ToString(days);
            lblHours.Text = Convert.ToString(hours);
            lblMinutes.Text = Convert.ToString(minutes);
            lblSeconds.Text = Convert.ToString(seconds);

            setLabelsVisible(true);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            setLabelsVisible(false);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
