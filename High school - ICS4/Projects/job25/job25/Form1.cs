using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job25
{
    public partial class Form1 : Form
    {
        static string[] teachers = new string[] { "Zvonar", "Kos", "Giancaterina", "", "Ziggy" };
        static string[] subjects = new string[] { "SPH", "MCR", "ICS", "LUNCH", "TEJ" };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void setTexts(int period)
        {
            lblTeacher.Text = teachers[period - 1];
            lblSubject.Text = subjects[period - 1];
        }

        private void rdo1_CheckedChanged(object sender, EventArgs e)
        {
            setTexts(1);
        }

        private void rdo2_CheckedChanged(object sender, EventArgs e)
        {
            setTexts(2);
        }

        private void rdo3_CheckedChanged(object sender, EventArgs e)
        {
            setTexts(3);
        }

        private void rdo4_CheckedChanged(object sender, EventArgs e)
        {
            setTexts(4);
        }

        private void rdo5_CheckedChanged(object sender, EventArgs e)
        {
            setTexts(5);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdo1.Checked = false;
            rdo2.Checked = false;
            rdo3.Checked = false;
            rdo4.Checked = false;
            rdo5.Checked = false;

            lblSubject.Text = "";
            lblTeacher.Text = "";
        }
    }
}
