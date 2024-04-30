namespace job26
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
            this.grpPrices = new System.Windows.Forms.GroupBox();
            this.rdoLow = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoHigh = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picPorsche = new System.Windows.Forms.PictureBox();
            this.picCorvette = new System.Windows.Forms.PictureBox();
            this.picMustang = new System.Windows.Forms.PictureBox();
            this.lblMustang = new System.Windows.Forms.Label();
            this.lblCorvette = new System.Windows.Forms.Label();
            this.lblPorshe = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpPrices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPorsche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorvette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMustang)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPrices
            // 
            this.grpPrices.Controls.Add(this.rdoHigh);
            this.grpPrices.Controls.Add(this.rdoMedium);
            this.grpPrices.Controls.Add(this.rdoLow);
            this.grpPrices.Location = new System.Drawing.Point(12, 12);
            this.grpPrices.Name = "grpPrices";
            this.grpPrices.Size = new System.Drawing.Size(79, 112);
            this.grpPrices.TabIndex = 0;
            this.grpPrices.TabStop = false;
            this.grpPrices.Text = "Price Range";
            // 
            // rdoLow
            // 
            this.rdoLow.AutoSize = true;
            this.rdoLow.Location = new System.Drawing.Point(7, 43);
            this.rdoLow.Name = "rdoLow";
            this.rdoLow.Size = new System.Drawing.Size(45, 17);
            this.rdoLow.TabIndex = 0;
            this.rdoLow.Text = "Low";
            this.rdoLow.UseVisualStyleBackColor = true;
            this.rdoLow.CheckedChanged += new System.EventHandler(this.rdoLow_CheckedChanged);
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Location = new System.Drawing.Point(6, 66);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(62, 17);
            this.rdoMedium.TabIndex = 1;
            this.rdoMedium.Text = "Medium";
            this.rdoMedium.UseVisualStyleBackColor = true;
            this.rdoMedium.CheckedChanged += new System.EventHandler(this.rdoMedium_CheckedChanged);
            // 
            // rdoHigh
            // 
            this.rdoHigh.AutoSize = true;
            this.rdoHigh.Location = new System.Drawing.Point(7, 89);
            this.rdoHigh.Name = "rdoHigh";
            this.rdoHigh.Size = new System.Drawing.Size(47, 17);
            this.rdoHigh.TabIndex = 2;
            this.rdoHigh.Text = "High";
            this.rdoHigh.UseVisualStyleBackColor = true;
            this.rdoHigh.CheckedChanged += new System.EventHandler(this.rdoHigh_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(231, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(116, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Select your price range";
            // 
            // picPorsche
            // 
            this.picPorsche.Image = global::job26.Properties.Resources.porsche;
            this.picPorsche.Location = new System.Drawing.Point(224, 176);
            this.picPorsche.Name = "picPorsche";
            this.picPorsche.Size = new System.Drawing.Size(123, 69);
            this.picPorsche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPorsche.TabIndex = 4;
            this.picPorsche.TabStop = false;
            this.picPorsche.Visible = false;
            // 
            // picCorvette
            // 
            this.picCorvette.Image = global::job26.Properties.Resources.corvette;
            this.picCorvette.Location = new System.Drawing.Point(224, 101);
            this.picCorvette.Name = "picCorvette";
            this.picCorvette.Size = new System.Drawing.Size(123, 69);
            this.picCorvette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCorvette.TabIndex = 3;
            this.picCorvette.TabStop = false;
            this.picCorvette.Visible = false;
            // 
            // picMustang
            // 
            this.picMustang.Image = global::job26.Properties.Resources.mustang;
            this.picMustang.Location = new System.Drawing.Point(224, 25);
            this.picMustang.Name = "picMustang";
            this.picMustang.Size = new System.Drawing.Size(123, 69);
            this.picMustang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMustang.TabIndex = 2;
            this.picMustang.TabStop = false;
            this.picMustang.Visible = false;
            // 
            // lblMustang
            // 
            this.lblMustang.AutoSize = true;
            this.lblMustang.Location = new System.Drawing.Point(354, 25);
            this.lblMustang.Name = "lblMustang";
            this.lblMustang.Size = new System.Drawing.Size(48, 13);
            this.lblMustang.TabIndex = 5;
            this.lblMustang.Text = "Mustang";
            this.lblMustang.Visible = false;
            // 
            // lblCorvette
            // 
            this.lblCorvette.AutoSize = true;
            this.lblCorvette.Location = new System.Drawing.Point(357, 101);
            this.lblCorvette.Name = "lblCorvette";
            this.lblCorvette.Size = new System.Drawing.Size(47, 13);
            this.lblCorvette.TabIndex = 6;
            this.lblCorvette.Text = "Corvette";
            this.lblCorvette.Visible = false;
            // 
            // lblPorshe
            // 
            this.lblPorshe.AutoSize = true;
            this.lblPorshe.Location = new System.Drawing.Point(360, 176);
            this.lblPorshe.Name = "lblPorshe";
            this.lblPorshe.Size = new System.Drawing.Size(40, 13);
            this.lblPorshe.TabIndex = 7;
            this.lblPorshe.Text = "Porshe";
            this.lblPorshe.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(484, 9);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(483, 221);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblPorshe);
            this.Controls.Add(this.lblCorvette);
            this.Controls.Add(this.lblMustang);
            this.Controls.Add(this.picPorsche);
            this.Controls.Add(this.picCorvette);
            this.Controls.Add(this.picMustang);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpPrices);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpPrices.ResumeLayout(false);
            this.grpPrices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPorsche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorvette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMustang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPrices;
        private System.Windows.Forms.RadioButton rdoHigh;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoLow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picMustang;
        private System.Windows.Forms.PictureBox picCorvette;
        private System.Windows.Forms.PictureBox picPorsche;
        private System.Windows.Forms.Label lblMustang;
        private System.Windows.Forms.Label lblCorvette;
        private System.Windows.Forms.Label lblPorshe;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

