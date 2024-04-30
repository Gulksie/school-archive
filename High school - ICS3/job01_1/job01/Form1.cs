using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace job01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the program
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            setButton(btnBegin, false);
            setButton(btnEnd, false);
            setText(textBox1, true);
            setText(textBox2, true);
            setText(textBox3, true);
            setButton(btnCalculate, true);
            setButton(btnBack, true);

        }

        void setButton(Button btn, bool type)
        {
            btn.Visible = type;
            btn.Enabled = type;
        }

        void setText(TextBox txt, bool type)
        {
            txt.Visible = type;
            txt.Enabled = type;
        }
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            long volume = 1;
            foreach (string i in new string[] { textBox1.Text, textBox2.Text, textBox3.Text })
            {
                try
                {
                    volume *= Convert.ToInt32(i);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                    return;
                }
            }

            MessageBox.Show("Volume is " + volume + " units squared");
            setButton(btnCalculate, false);
            foreach (TextBox i in new TextBox[] { textBox1, textBox2, textBox3 })
            {
                setText(i, false);
            }

            setButton(btnBegin, true);
            setButton(btnEnd, true);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            setButton(btnCalculate, false);
            setButton(btnBack, false);
            foreach (TextBox i in new TextBox[] { textBox1, textBox2, textBox3 })
            {
                setText(i, false);
            }

            setButton(btnBegin, true);
            setButton(btnEnd, true);
        }
    }
}
