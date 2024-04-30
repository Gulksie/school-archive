using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job86
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
            string check = txtMain.Text;
            lblMain.Text = (isPal(check.ToLower(), 0) != null).ToString();
        }

        string isPal(string check, int currentChar)
        {
            if (currentChar >= check.Length)
            {
                return check;
            }
            if (check[currentChar] == check[check.Length - currentChar - 1])
            {
                return isPal(check, currentChar + 1);
            }
            else
            {
                return null;
            }
        }
    }
}
