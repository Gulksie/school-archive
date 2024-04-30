namespace job22
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
            this.btnStart = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblYearTitle = new System.Windows.Forms.Label();
            this.lblMonthsTitle = new System.Windows.Forms.Label();
            this.lblDaysTitle = new System.Windows.Forms.Label();
            this.lblHoursTitle = new System.Windows.Forms.Label();
            this.lblMinutesTitle = new System.Windows.Forms.Label();
            this.lblSecondsTitle = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblMonths = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(71, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(135, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Click here to begin";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(13, 227);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(197, 227);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 2;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(44, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "This is how old you are";
            // 
            // lblYearTitle
            // 
            this.lblYearTitle.AutoSize = true;
            this.lblYearTitle.Location = new System.Drawing.Point(10, 72);
            this.lblYearTitle.Name = "lblYearTitle";
            this.lblYearTitle.Size = new System.Drawing.Size(51, 13);
            this.lblYearTitle.TabIndex = 4;
            this.lblYearTitle.Text = "Years old";
            // 
            // lblMonthsTitle
            // 
            this.lblMonthsTitle.AutoSize = true;
            this.lblMonthsTitle.Location = new System.Drawing.Point(10, 85);
            this.lblMonthsTitle.Name = "lblMonthsTitle";
            this.lblMonthsTitle.Size = new System.Drawing.Size(59, 13);
            this.lblMonthsTitle.TabIndex = 5;
            this.lblMonthsTitle.Text = "Months old";
            // 
            // lblDaysTitle
            // 
            this.lblDaysTitle.AutoSize = true;
            this.lblDaysTitle.Location = new System.Drawing.Point(10, 98);
            this.lblDaysTitle.Name = "lblDaysTitle";
            this.lblDaysTitle.Size = new System.Drawing.Size(31, 13);
            this.lblDaysTitle.TabIndex = 6;
            this.lblDaysTitle.Text = "Days";
            // 
            // lblHoursTitle
            // 
            this.lblHoursTitle.AutoSize = true;
            this.lblHoursTitle.Location = new System.Drawing.Point(10, 111);
            this.lblHoursTitle.Name = "lblHoursTitle";
            this.lblHoursTitle.Size = new System.Drawing.Size(35, 13);
            this.lblHoursTitle.TabIndex = 7;
            this.lblHoursTitle.Text = "Hours";
            // 
            // lblMinutesTitle
            // 
            this.lblMinutesTitle.AutoSize = true;
            this.lblMinutesTitle.Location = new System.Drawing.Point(10, 124);
            this.lblMinutesTitle.Name = "lblMinutesTitle";
            this.lblMinutesTitle.Size = new System.Drawing.Size(44, 13);
            this.lblMinutesTitle.TabIndex = 8;
            this.lblMinutesTitle.Text = "Minutes";
            // 
            // lblSecondsTitle
            // 
            this.lblSecondsTitle.AutoSize = true;
            this.lblSecondsTitle.Location = new System.Drawing.Point(10, 137);
            this.lblSecondsTitle.Name = "lblSecondsTitle";
            this.lblSecondsTitle.Size = new System.Drawing.Size(49, 13);
            this.lblSecondsTitle.TabIndex = 9;
            this.lblSecondsTitle.Text = "Seconds";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.BackColor = System.Drawing.Color.White;
            this.lblYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYears.Location = new System.Drawing.Point(170, 71);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(2, 15);
            this.lblYears.TabIndex = 10;
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.BackColor = System.Drawing.Color.White;
            this.lblMonths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonths.Location = new System.Drawing.Point(170, 83);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(2, 15);
            this.lblMonths.TabIndex = 11;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.BackColor = System.Drawing.Color.White;
            this.lblDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDays.Location = new System.Drawing.Point(170, 98);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(2, 15);
            this.lblDays.TabIndex = 12;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.BackColor = System.Drawing.Color.White;
            this.lblHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHours.Location = new System.Drawing.Point(170, 111);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(2, 15);
            this.lblHours.TabIndex = 13;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.BackColor = System.Drawing.Color.White;
            this.lblMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMinutes.Location = new System.Drawing.Point(170, 122);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(2, 15);
            this.lblMinutes.TabIndex = 14;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.BackColor = System.Drawing.Color.White;
            this.lblSeconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeconds.Location = new System.Drawing.Point(170, 135);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(2, 15);
            this.lblSeconds.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblMonths);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblSecondsTitle);
            this.Controls.Add(this.lblMinutesTitle);
            this.Controls.Add(this.lblHoursTitle);
            this.Controls.Add(this.lblDaysTitle);
            this.Controls.Add(this.lblMonthsTitle);
            this.Controls.Add(this.lblYearTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblYearTitle;
        private System.Windows.Forms.Label lblMonthsTitle;
        private System.Windows.Forms.Label lblDaysTitle;
        private System.Windows.Forms.Label lblHoursTitle;
        private System.Windows.Forms.Label lblMinutesTitle;
        private System.Windows.Forms.Label lblSecondsTitle;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSeconds;
    }
}

