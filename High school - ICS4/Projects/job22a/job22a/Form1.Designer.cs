namespace job22a
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFirstMark = new System.Windows.Forms.Label();
            this.txtFirstMark = new System.Windows.Forms.TextBox();
            this.txtSecondMark = new System.Windows.Forms.TextBox();
            this.lblSecondMark = new System.Windows.Forms.Label();
            this.btnAverage = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(82, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(99, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Calculate Averages";
            // 
            // lblFirstMark
            // 
            this.lblFirstMark.AutoSize = true;
            this.lblFirstMark.Location = new System.Drawing.Point(12, 39);
            this.lblFirstMark.Name = "lblFirstMark";
            this.lblFirstMark.Size = new System.Drawing.Size(77, 13);
            this.lblFirstMark.TabIndex = 1;
            this.lblFirstMark.Text = "Enter first mark";
            // 
            // txtFirstMark
            // 
            this.txtFirstMark.Location = new System.Drawing.Point(13, 56);
            this.txtFirstMark.Name = "txtFirstMark";
            this.txtFirstMark.Size = new System.Drawing.Size(100, 20);
            this.txtFirstMark.TabIndex = 2;
            // 
            // txtSecondMark
            // 
            this.txtSecondMark.Location = new System.Drawing.Point(172, 55);
            this.txtSecondMark.Name = "txtSecondMark";
            this.txtSecondMark.Size = new System.Drawing.Size(100, 20);
            this.txtSecondMark.TabIndex = 4;
            // 
            // lblSecondMark
            // 
            this.lblSecondMark.AutoSize = true;
            this.lblSecondMark.Location = new System.Drawing.Point(171, 39);
            this.lblSecondMark.Name = "lblSecondMark";
            this.lblSecondMark.Size = new System.Drawing.Size(96, 13);
            this.lblSecondMark.TabIndex = 3;
            this.lblSecondMark.Text = "Enter second mark";
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(85, 117);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(118, 20);
            this.btnAverage.TabIndex = 5;
            this.btnAverage.Text = "Calculate Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // lblOut
            // 
            this.lblOut.BackColor = System.Drawing.Color.White;
            this.lblOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOut.Location = new System.Drawing.Point(94, 161);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(100, 23);
            this.lblOut.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.txtSecondMark);
            this.Controls.Add(this.lblSecondMark);
            this.Controls.Add(this.txtFirstMark);
            this.Controls.Add(this.lblFirstMark);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFirstMark;
        private System.Windows.Forms.TextBox txtFirstMark;
        private System.Windows.Forms.TextBox txtSecondMark;
        private System.Windows.Forms.Label lblSecondMark;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label lblOut;
    }
}

