using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace assign4
{
    public partial class Form1 : Form
    {
        static string[] stockNames = { "T", "BCE", "BNS", "ENB", "TPR", "RBC" };
        static double[] costPerShare = { 48.66, 59.85, 72.08, 49.30, 63.10, 105.41 };

        int[,] shares; //where we will put our shares
        int[] totals; //the "total shares" column

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
            StreamReader sr = new StreamReader(@"W:\files\stockSplitFile.txt"); //open the file

            string read = sr.ReadLine(); //buffer our first line
            shares = new int[100, 5]; //100 because we don't know the amount of stocks

            int count = 0; //because we dont know the amount of stocks, we can't use a for loop
            while (read != null) //read will be null at the end of the file
            {
                string[] split = read.Split('	'); //split on indent (tab key)

                for (int i = 0; i < 5; i++) //we know there are 5 columns
                {
                    shares[count, i] = Convert.ToInt32(split[i]); //convert to an int and put it into the array
                }
                read = sr.ReadLine(); //buffer the next line
                count++;
            }

            sr.Close(); //close the file

            totals = new int[count]; //we can use count here because we know it stopped incrementing when the file ended
            string txtOut = "Stock Name    Cost per share    Investors' Edge    Royal Direct       Investorline       TD Direct          Scotia Itrade      Total Shares\n";

            for (int i = 0; i < count; i++)
            {
                totals[i] = 0; //get this ready to calculate the total

                txtOut += stockNames[i].PadRight(14); //put the stock name in
                txtOut += costPerShare[i].ToString().PadRight(18); //put the cost per share in

                for (int j = 0; j < 5; j++)
                {
                    txtOut += shares[i, j].ToString().PadRight(19); //add each share
                    totals[i] += shares[i, j]; //calculate the total
                }

                txtOut += totals[i].ToString().PadRight(12); //add the total to the chart
                txtOut += "\n";
            }

            int total = 0;
            //loop through all the totals, and calculate the grand total (sum of totals)
            foreach (int i in totals)
            {
                total += i;
            }

            txtOut += total.ToString().PadLeft(131); //add the grand total

            lblMain.Text = txtOut; //set our output to our working string
        }
    }
}
