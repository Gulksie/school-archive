using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace job17
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
            lblMain.Text = "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int tiles = Convert.ToInt32(Interaction.InputBox("Enter amount of tiles"));

            int boxes = tiles / 10;
            if (tiles % 10 != 0)
                boxes++;

            lblMain.Text = "You will need " + boxes + " boxes.";
        }
    }
}
