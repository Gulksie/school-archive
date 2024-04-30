namespace job35
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.sbYear = new System.Windows.Forms.VScrollBar();
            this.sbMonth = new System.Windows.Forms.VScrollBar();
            this.sbDay = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Birthday";
            // 
            // sbYear
            // 
            this.sbYear.LargeChange = 1;
            this.sbYear.Location = new System.Drawing.Point(24, 76);
            this.sbYear.Maximum = 2010;
            this.sbYear.Minimum = 1985;
            this.sbYear.Name = "sbYear";
            this.sbYear.Size = new System.Drawing.Size(17, 115);
            this.sbYear.TabIndex = 1;
            this.sbYear.Value = 1985;
            this.sbYear.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbYear_Scroll);
            // 
            // sbMonth
            // 
            this.sbMonth.LargeChange = 1;
            this.sbMonth.Location = new System.Drawing.Point(102, 76);
            this.sbMonth.Maximum = 11;
            this.sbMonth.Name = "sbMonth";
            this.sbMonth.Size = new System.Drawing.Size(17, 115);
            this.sbMonth.TabIndex = 2;
            this.sbMonth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbMonth_Scroll);
            // 
            // sbDay
            // 
            this.sbDay.LargeChange = 1;
            this.sbDay.Location = new System.Drawing.Point(188, 76);
            this.sbDay.Maximum = 31;
            this.sbDay.Minimum = 1;
            this.sbDay.Name = "sbDay";
            this.sbDay.Size = new System.Drawing.Size(17, 115);
            this.sbDay.TabIndex = 3;
            this.sbDay.Value = 1;
            this.sbDay.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbDay_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Day";
            // 
            // lblYear
            // 
            this.lblYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYear.Location = new System.Drawing.Point(12, 208);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(60, 23);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "1985";
            // 
            // lblMonth
            // 
            this.lblMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonth.Location = new System.Drawing.Point(84, 208);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(60, 23);
            this.lblMonth.TabIndex = 8;
            this.lblMonth.Text = "January";
            // 
            // lblDay
            // 
            this.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDay.Location = new System.Drawing.Point(167, 208);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(60, 23);
            this.lblDay.TabIndex = 9;
            this.lblDay.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 262);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sbDay);
            this.Controls.Add(this.sbMonth);
            this.Controls.Add(this.sbYear);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar sbYear;
        private System.Windows.Forms.VScrollBar sbMonth;
        private System.Windows.Forms.VScrollBar sbDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDay;
    }
}

