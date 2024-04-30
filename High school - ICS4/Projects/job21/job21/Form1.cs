using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace job21
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
            string first, last;

            first = Interaction.InputBox("Enter your first name");
            last = Interaction.InputBox("Enter your last name");

            lblFirstName.Text = first;
            lblLastName.Text = last;

            lblFirstName.Visible = true;
            lblFirstNameTitle.Visible = true;
            lblLastName.Visible = true;
            lblLastNameTitle.Visible = true;

            btnStart.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblFirstName.Visible = false;
            lblFirstNameTitle.Visible = false;
            lblLastName.Visible = false;
            lblLastNameTitle.Visible = false;

            btnStart.Enabled = true;
        }
    }
}
