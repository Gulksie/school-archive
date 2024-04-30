using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job38
{
    public partial class Form1 : Form
    {
        string[] stores = { "Home Hardware", "Home Depot", "Lowes" };
        int[,] prices = {{45, 67, 34, 21}, {73, 84, 44, 0}, {33, 12, 46, 90}};
        int[] totalsx = new int[4];
        int[] totalsy = new int[3];
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
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    total += prices[i, j];
                }
                totalsy[i] = total;
                total = 0;
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    total += prices[j, i];
                }
                totalsx[i] = total;
                total = 0;
            }

            foreach (int i in totalsy)
            {
                total += i;
            }

            string txtOut = "Warehouse Name    Item1    Item2    Item3    Item4    Total\n";

            for (int i = 0; i < 3; i++)
            {
                txtOut += stores[i].PadRight(18);
                for (int j = 0; j < 4; j++)
                {
                    txtOut += prices[i, j].ToString().PadRight(9);
                }

                txtOut += totalsy[i].ToString().PadRight(5) + "\n";
            }

            txtOut += "Total".PadRight(18);
            foreach (int i in totalsx)
            {
                txtOut += i.ToString().PadRight(9);
            }
            txtOut += total.ToString().PadRight(9) + "\n";

            lblMain.Text = txtOut;
        }
    }
}
