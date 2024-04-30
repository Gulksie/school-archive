using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*Michael Gulka, 9/8/17, job01
This program uses command buttons and numeric varibles to
calculate the area of a rectangle*/

namespace job01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnd_click(object sender, EventArgs e)
        {
            this.Close(); //closes the program
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            //declare vars
            double length;
            double width;
            double height;

            //assign values for length, width, and height
            length = 5;
            width = 3;
            height = 4;

            double volume = length * width * height; //calculate volume

            //show results
            MessageBox.Show("The volume of the rectangle is " + volume + " cm squared.");
        }
    }
}
