using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace job42
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
            StreamReader f = new StreamReader(@"W:\files\classMark.txt");

            string[] names = new string[100];
            int[] marks = new int[100];
            double average = 0;
            int count = 0;
            string read = f.ReadLine();
            names[0] = read;

            while (read != null)
            {
                read = f.ReadLine();
                marks[count] = Convert.ToInt32(read);
                average += marks[count];

                count++;
                read = f.ReadLine();
                names[count] = read;
            }

            for (int i = 0; i < names.Length; i++)
            { 

            }
        }
    }
}
