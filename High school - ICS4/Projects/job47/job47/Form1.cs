using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ICS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblMain.Text = "";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader(@"W:\files\country.txt");

            lblMain.Text = f.ReadToEnd();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader(@"W:\files\movies.txt");

            lblMain.Text = f.ReadToEnd();
        }

        private void btnOlympic_Click(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader(@"W:\files\olympic countries Not Alpha.txt");

            string[] arr = f.ReadToEnd().Split(new[] {Environment.NewLine},
                StringSplitOptions.None);

            lblMain.Text = "";
            foreach (string i in arr) {
                lblMain.Text += i;
                lblMain.Text += "\n";
            }
        }
    }
}
