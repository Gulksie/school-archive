namespace job24
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
            this.grpLunch = new System.Windows.Forms.GroupBox();
            this.rdoLunch2 = new System.Windows.Forms.RadioButton();
            this.rdoLunch3 = new System.Windows.Forms.RadioButton();
            this.rdoLunch4 = new System.Windows.Forms.RadioButton();
            this.lblOut = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.grpLunch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(86, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(94, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LUNCH CHOICES";
            // 
            // grpLunch
            // 
            this.grpLunch.Controls.Add(this.rdoLunch4);
            this.grpLunch.Controls.Add(this.rdoLunch3);
            this.grpLunch.Controls.Add(this.rdoLunch2);
            this.grpLunch.Location = new System.Drawing.Point(12, 43);
            this.grpLunch.Name = "grpLunch";
            this.grpLunch.Size = new System.Drawing.Size(260, 94);
            this.grpLunch.TabIndex = 1;
            this.grpLunch.TabStop = false;
            // 
            // rdoLunch2
            // 
            this.rdoLunch2.AutoSize = true;
            this.rdoLunch2.Location = new System.Drawing.Point(7, 20);
            this.rdoLunch2.Name = "rdoLunch2";
            this.rdoLunch2.Size = new System.Drawing.Size(95, 17);
            this.rdoLunch2.TabIndex = 0;
            this.rdoLunch2.Text = "Second Lunch";
            this.rdoLunch2.UseVisualStyleBackColor = true;
            this.rdoLunch2.CheckedChanged += new System.EventHandler(this.rdoLunch2_CheckedChanged);
            // 
            // rdoLunch3
            // 
            this.rdoLunch3.AutoSize = true;
            this.rdoLunch3.Location = new System.Drawing.Point(7, 44);
            this.rdoLunch3.Name = "rdoLunch3";
            this.rdoLunch3.Size = new System.Drawing.Size(82, 17);
            this.rdoLunch3.TabIndex = 1;
            this.rdoLunch3.Text = "Third Lunch";
            this.rdoLunch3.UseVisualStyleBackColor = true;
            this.rdoLunch3.CheckedChanged += new System.EventHandler(this.rdoLunch3_CheckedChanged);
            // 
            // rdoLunch4
            // 
            this.rdoLunch4.AutoSize = true;
            this.rdoLunch4.Location = new System.Drawing.Point(7, 68);
            this.rdoLunch4.Name = "rdoLunch4";
            this.rdoLunch4.Size = new System.Drawing.Size(88, 17);
            this.rdoLunch4.TabIndex = 2;
            this.rdoLunch4.Text = "Fourth Lunch";
            this.rdoLunch4.UseVisualStyleBackColor = true;
            this.rdoLunch4.CheckedChanged += new System.EventHandler(this.rdoLunch4_CheckedChanged);
            // 
            // lblOut
            // 
            this.lblOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOut.Location = new System.Drawing.Point(19, 180);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(253, 23);
            this.lblOut.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(197, 227);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.grpLunch);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpLunch.ResumeLayout(false);
            this.grpLunch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpLunch;
        private System.Windows.Forms.RadioButton rdoLunch4;
        private System.Windows.Forms.RadioButton rdoLunch3;
        private System.Windows.Forms.RadioButton rdoLunch2;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnd;
    }
}

