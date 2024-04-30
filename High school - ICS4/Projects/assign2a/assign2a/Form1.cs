//Michael Gulka, ICS 4U1
//the purpose of this program is to select vaction destinations, show pictures, and display
//average temperatures
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace assign2a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changeRdo(object sender, EventArgs e)
        {
            //set all our pictures to invisible so we don't try to draw 2
            picAruba.Visible = false;
            picBarbados.Visible = false;
            picJamaica.Visible = false;

            //check which destination is checked
            if (rdoJamaica.Checked)
            {
                picJamaica.Visible = true;

                //now check which month and display temperature
                if (rdoOctober.Checked)
                    lblTemperature.Text = "30";
                else if (rdoNovember.Checked)
                    lblTemperature.Text = "28";
                else if (rdoDecember.Checked)
                    lblTemperature.Text = "27";
            }
            else if (rdoAruba.Checked)
            {
                picAruba.Visible = true;

                //now check which month and display temperature
                if (rdoOctober.Checked)
                    lblTemperature.Text = "32";
                else if (rdoNovember.Checked)
                    lblTemperature.Text = "31";
                else if (rdoDecember.Checked)
                    lblTemperature.Text = "30";
            }
            else //barbados is checked 
            {
                picBarbados.Visible = true;

                //now check which month and display temperature
                if (rdoOctober.Checked)
                    lblTemperature.Text = "31";
                else if (rdoNovember.Checked)
                    lblTemperature.Text = "29";
                else if (rdoDecember.Checked)
                    lblTemperature.Text = "26";
            }
        }
    }
}
