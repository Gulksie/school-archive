using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;


namespace job47
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
            List<String> names = new List<string>();

            while (true)
            {
                string input = Interaction.InputBox("Enter name");

                if (input.ToLower() == "stop") {
                    break;
                }

                names.Add(input);
            }

            StreamWriter sw = new StreamWriter(@"W:\\files\\friends.txt");

            foreach (string i in names) {
                sw.WriteLine(i);
            }
            sw.Close();


            StreamReader sr = new StreamReader(@"W:\\files\\friends.txt");
            string value = "not null";
            do
            {
                value = sr.ReadLine();
                lblMain.Text += value + "\n";
            } while (value != null);

            sr.Close();
        }
    }
}
