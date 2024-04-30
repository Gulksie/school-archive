using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace assign3a
{
    public partial class Form1 : Form
    {
        int[] shares; //the amount of shares we have
        int[] cost; //each share's price
        int[] total; //the total price of each type of share
        string read; //the value we read from the file
        int count; //used as an increment to acess arrays while reading the file
        StreamReader sr; //used to read the file
        string txtOut; //we construct our output here before we assign it to lblMain.Text

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
            //set all arrays to length of 100 because we dont know how many shares there is
            shares = new int[100];
            cost = new int[100];
            total = new int[100];

            sr = new StreamReader(@"W:\files\stock.txt"); //load the file
            count = 0;

            //read the file
            do
            {
                read = sr.ReadLine();

                if (read != null) //only shares will be null
                {
                    //read shares, then cost
                    shares[count] = Convert.ToInt32(read);

                    read = sr.ReadLine();

                    cost[count] = Convert.ToInt32(read);

                    //calculate total
                    total[count] = shares[count] * cost[count];
                }
                count++;
            } while (read != null);

            //table headings
            txtOut = "STOCK #     NUMBER OF SHARES     COST OF EACH SHARE     TOTAL VALUE OF EACH STOCK";

            for (int i = 0; i < shares.Length; i++) //loop through each share
            {
                if (shares[i] != 0) //we dont care about something if we dont have any shares
                {
                    //use txtOut instead of directly assigning to lblMain because its easier
                    //for me to understand :)
                    txtOut += "\n"; //add a newline each time we add a row

                    //add our data
                    txtOut += (i + 1) + "     " + shares[i] + "     " + cost[i] + "     " + total[i];
                }
            }

            lblMain.Text = txtOut;
        }
    }
}
