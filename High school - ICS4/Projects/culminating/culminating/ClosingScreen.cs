using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace culminating
{
    public partial class Closing : Form
    {
        public Closing()
        {
            InitializeComponent();
        }
         
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
