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
        bool done = false; //if we are done the bubble sort
        string[] cities = new string[100]; //our cities that we read from the file
        StreamReader sr; //used to read the file
        string read; //what we read from our streamreader
        int count = 0; //counter used when reading the file

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
            done = false;
            cities = new string[100];
            count = 0;

            sr = new StreamReader(@"W:\files\topOntCitiestoLive.txt"); //read our file

            //read the file into the cities[] array
            do
            {
                read = sr.ReadLine();

                if (read != null)
                    cities[count] = read;

                count++;
            } while (read != null);

            //bubble sort
            do
            {
                done = true;
                for (int i = 0; i < cities.Length; i++) {
                    if (cities[i] != null && cities[i+1] != null) //we dont want to sort our null values, they should all be at the back
                    {
                        if (cities[i].CompareTo(cities[i+1]) == 1) //[i+1] is higher alphabletically then [i]
                        {
                            //swap their positions in the array
                            string tmp = cities[i + 1];
                            cities[i + 1] = cities[i];
                            cities[i] = tmp;
                            done = false;
                        }
                    }
                }
            } while (!done);

            //display the array
            foreach (string i in cities)
            {
                if (i != null) //we don't care about null
                {
                    lblMain.Text += i + '\n';
                }
            }
        }
    }
}
