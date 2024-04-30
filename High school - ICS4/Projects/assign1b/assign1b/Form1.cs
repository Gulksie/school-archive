//Michael Gulka, assign1b
//The purpose of this assignment is to calculate the volume and cost of a pool
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ICS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            double length = 0;
            double width = 0;
            double depth = 0;

            bool loop = true;

            while (loop) //for error checking, loop is only set to false when all inputs are correct
            {
                try
                {
                    width = Convert.ToDouble(Interaction.InputBox("Enter width", "Width"));
                    length = Convert.ToDouble(Interaction.InputBox("Enter length", "Length"));
                    depth = Convert.ToDouble(Interaction.InputBox("Enter average depth", "depth"));
                    loop = false;
                }
                catch (FormatException) //one of those inputs isnt a number
                {
                    loop = true;
                }
            }

            double volume = length * width * depth;
            double cost = Math.Round(volume * 150, 2); //round cost (volume * 150) to 2 places

            lblMain.Text = "The volume of the pool is " + volume + " cubic meters and the cost is $" + cost;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMain.Text = "";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
