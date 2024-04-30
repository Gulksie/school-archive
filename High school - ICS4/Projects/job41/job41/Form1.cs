using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace job41
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
            StreamReader f = new StreamReader(@"W:\files\scores.txt");
            
            string read = f.ReadLine();
            double average = 0;
            int count = 0;
            while (read != null) {
                lblMain.Text += read + "\n";

                average += Convert.ToInt32(read);
                count++;

                read = f.ReadLine();
            }

            lblMain.Text += Convert.ToString(average/count);
        }
    }
}
