using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job39
{
    public partial class Form1 : Form
    {
        int[,] items = { { 50, 0, 16, 2 }, { 3, 4, 0, 98 }, { 0, 1, 4, 22 } };
        int[] totals = new int[4];
        int total;
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
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    total += items[i, j];
                }

                totals[i] = total;
                total = 0;
            }

            string txtOut = "Total".PadLeft(19) + "\n";
            for (int i = 0; i < 3; i++)
            {
                txtOut += ("Warehouse" + i).PadRight(14);
                txtOut += totals[i].ToString().PadRight(5);
                txtOut += "\n";
                total += totals[i];
            }

            txtOut += "Total".PadRight(14);
            txtOut += total.ToString().PadRight(5);

            lblMain.Text = txtOut;
        }
    }
}
