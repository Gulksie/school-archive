using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace job03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Enter name", "Name");

            string number = Interaction.InputBox("Enter phone #", "Phone");

            int grade = 12;
            while (true) {
                string tmp = Interaction.InputBox("Enter grade (INT)", "Grade");

                try
                {
                    grade = Convert.ToInt32(tmp);
                    break;
                }
                catch (FormatException)
                {
                    MessageBox.Show("INPUT NOT AN INT", "Error");
                    continue;
                }
            }

            MessageBox.Show(name + "'s phone number is " + number + "\n" + name +
                " is in grade " + grade);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
