using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job60
{
    public partial class Form1 : Form
    {
        Button[] buttons = new Button[12];
        string[] months = { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int working = i * 4 + j;
                    buttons[working] = new Button();
                    buttons[working].Size = new Size(100, 50);
                    buttons[working].Text = months[working];
                    buttons[working].Tag = working;

                    buttons[working].Location = new Point(60 + j * 100, 230 + i * 50);

                    buttons[working].Click += new EventHandler(this.btnClick);

                    Controls.Add(buttons[working]);
                }
            }
        }

        private void btnClick(Object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Button)sender).Tag);

            lblMonth.Text = months[index];
            lblDays.Text = days[index].ToString();
        }
    }
}
