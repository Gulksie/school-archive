//Michael Gulka
//This program uses command buttons and numeric varibles to calculate the volume of a rectangle
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmVol : Form
    {
        public frmVol()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //dimensions of shape
            int length = 5;
            int width = 3;
            int height = 4;

            int volume;

            volume = length * width * height;
            MessageBox.Show("The volume is " + volume + " cubic cm");
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            //stop
            this.Close();
        }
    }
}
