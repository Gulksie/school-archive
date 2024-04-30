namespace job28
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
            this.grpColour = new System.Windows.Forms.GroupBox();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.rdoYellow = new System.Windows.Forms.RadioButton();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rdoM = new System.Windows.Forms.RadioButton();
            this.rdoL = new System.Windows.Forms.RadioButton();
            this.rdoXL = new System.Windows.Forms.RadioButton();
            this.rdoS = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutColour = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOutSize = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grpColour.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpColour
            // 
            this.grpColour.Controls.Add(this.rdoYellow);
            this.grpColour.Controls.Add(this.rdoGreen);
            this.grpColour.Controls.Add(this.rdoRed);
            this.grpColour.Location = new System.Drawing.Point(12, 12);
            this.grpColour.Name = "grpColour";
            this.grpColour.Size = new System.Drawing.Size(103, 97);
            this.grpColour.TabIndex = 0;
            this.grpColour.TabStop = false;
            this.grpColour.Text = "T-shirt Colour";
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(7, 20);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(45, 17);
            this.rdoRed.TabIndex = 0;
            this.rdoRed.Text = "Red";
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new System.EventHandler(this.rdoRed_CheckedChanged);
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.Location = new System.Drawing.Point(6, 43);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(54, 17);
            this.rdoGreen.TabIndex = 1;
            this.rdoGreen.Text = "Green";
            this.rdoGreen.UseVisualStyleBackColor = true;
            this.rdoGreen.CheckedChanged += new System.EventHandler(this.rdoGreen_CheckedChanged);
            // 
            // rdoYellow
            // 
            this.rdoYellow.AutoSize = true;
            this.rdoYellow.Location = new System.Drawing.Point(6, 66);
            this.rdoYellow.Name = "rdoYellow";
            this.rdoYellow.Size = new System.Drawing.Size(56, 17);
            this.rdoYellow.TabIndex = 2;
            this.rdoYellow.Text = "Yellow";
            this.rdoYellow.UseVisualStyleBackColor = true;
            this.rdoYellow.CheckedChanged += new System.EventHandler(this.rdoYellow_CheckedChanged);
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rdoS);
            this.grpSize.Controls.Add(this.rdoM);
            this.grpSize.Controls.Add(this.rdoL);
            this.grpSize.Controls.Add(this.rdoXL);
            this.grpSize.Location = new System.Drawing.Point(151, 12);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(103, 117);
            this.grpSize.TabIndex = 3;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "T-shirt Colour";
            // 
            // rdoM
            // 
            this.rdoM.AutoSize = true;
            this.rdoM.Location = new System.Drawing.Point(6, 66);
            this.rdoM.Name = "rdoM";
            this.rdoM.Size = new System.Drawing.Size(34, 17);
            this.rdoM.TabIndex = 2;
            this.rdoM.Text = "M";
            this.rdoM.UseVisualStyleBackColor = true;
            this.rdoM.CheckedChanged += new System.EventHandler(this.rdoM_CheckedChanged);
            // 
            // rdoL
            // 
            this.rdoL.AutoSize = true;
            this.rdoL.Location = new System.Drawing.Point(6, 43);
            this.rdoL.Name = "rdoL";
            this.rdoL.Size = new System.Drawing.Size(31, 17);
            this.rdoL.TabIndex = 1;
            this.rdoL.Text = "L";
            this.rdoL.UseVisualStyleBackColor = true;
            this.rdoL.CheckedChanged += new System.EventHandler(this.rdoL_CheckedChanged);
            // 
            // rdoXL
            // 
            this.rdoXL.AutoSize = true;
            this.rdoXL.Location = new System.Drawing.Point(7, 20);
            this.rdoXL.Name = "rdoXL";
            this.rdoXL.Size = new System.Drawing.Size(38, 17);
            this.rdoXL.TabIndex = 0;
            this.rdoXL.Text = "XL";
            this.rdoXL.UseVisualStyleBackColor = true;
            this.rdoXL.CheckedChanged += new System.EventHandler(this.rdoXL_CheckedChanged);
            // 
            // rdoS
            // 
            this.rdoS.AutoSize = true;
            this.rdoS.Location = new System.Drawing.Point(7, 90);
            this.rdoS.Name = "rdoS";
            this.rdoS.Size = new System.Drawing.Size(32, 17);
            this.rdoS.TabIndex = 3;
            this.rdoS.Text = "S";
            this.rdoS.UseVisualStyleBackColor = true;
            this.rdoS.CheckedChanged += new System.EventHandler(this.rdoS_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "You have chosen";
            // 
            // lblOutColour
            // 
            this.lblOutColour.BackColor = System.Drawing.Color.White;
            this.lblOutColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutColour.Location = new System.Drawing.Point(109, 139);
            this.lblOutColour.Name = "lblOutColour";
            this.lblOutColour.Size = new System.Drawing.Size(100, 13);
            this.lblOutColour.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "colour and size";
            // 
            // lblOutSize
            // 
            this.lblOutSize.BackColor = System.Drawing.Color.White;
            this.lblOutSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutSize.Location = new System.Drawing.Point(300, 137);
            this.lblOutSize.Name = "lblOutSize";
            this.lblOutSize.Size = new System.Drawing.Size(100, 13);
            this.lblOutSize.TabIndex = 7;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(179, 183);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 228);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblOutSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOutColour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.grpColour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpColour.ResumeLayout(false);
            this.grpColour.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpColour;
        private System.Windows.Forms.RadioButton rdoYellow;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rdoS;
        private System.Windows.Forms.RadioButton rdoM;
        private System.Windows.Forms.RadioButton rdoL;
        private System.Windows.Forms.RadioButton rdoXL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOutColour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOutSize;
        private System.Windows.Forms.Button btnConfirm;
    }
}

