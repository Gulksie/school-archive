using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace job53
{
    public partial class Form1 : Form
    {
        int[,] votes = new int[6, 3];
        string[] cadidates = new string[6];
        int[] totalsx = new int[3];
        int[] totalsy = new int[6];
        int total = 0;

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
            total = 0;
            StreamReader sr = new StreamReader(@"W:\files\votes.txt");
            string txtOut = "Candidate    Region 1    Region 2    Region 3    Total\n";

            for (int i = 0; i < 6; i++)
            {
                cadidates[i] = sr.ReadLine().Replace("\n", "");
                totalsy[i] = 0;

                txtOut += cadidates[i].PadRight(14);

                for (int j = 0; j < 3; j++)
                {
                    votes[i, j] = Convert.ToInt32(sr.ReadLine().Replace("\n", ""));
                    totalsy[i] += votes[i, j];
                    txtOut += votes[i, j].ToString().PadRight(12);
                }

                txtOut += totalsy[i].ToString().PadRight(5) + "\n";
            }

            txtOut += "Total".PadRight(14);
            for (int i = 0; i < 3; i++)
            {
                totalsx[i] = 0;
                for (int j = 0; j < 6; j++)
                {
                    totalsx[i] += votes[j, i];
                }

                txtOut += totalsx[i].ToString().PadRight(12);
                total += totalsx[i];
            }

            txtOut += total.ToString().PadRight(5);

            lblMain.Text = txtOut;
        }
    }
}
