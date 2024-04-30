using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job85
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            String manipluate = txtIn.Text;
            lblMain.Text = reverse("", manipluate, manipluate.Length-1);
        }

        string reverse(string modify, string inital, int currentChar) {
            if (currentChar < 0)
            {
                return modify;
            }
            modify += inital[currentChar];
            return reverse(modify, inital, currentChar - 1);
        }
    }
}
