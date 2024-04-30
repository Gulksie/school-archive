namespace job06
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
            this.btnAF = new System.Windows.Forms.Button();
            this.btnGN = new System.Windows.Forms.Button();
            this.btnOZ = new System.Windows.Forms.Button();
            this.lblVP = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAF
            // 
            this.btnAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAF.Location = new System.Drawing.Point(0, 1);
            this.btnAF.Name = "btnAF";
            this.btnAF.Size = new System.Drawing.Size(86, 43);
            this.btnAF.TabIndex = 0;
            this.btnAF.Text = "A-F";
            this.btnAF.UseVisualStyleBackColor = true;
            this.btnAF.Click += new System.EventHandler(this.btnAF_Click);
            // 
            // btnGN
            // 
            this.btnGN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGN.Location = new System.Drawing.Point(92, 1);
            this.btnGN.Name = "btnGN";
            this.btnGN.Size = new System.Drawing.Size(85, 43);
            this.btnGN.TabIndex = 1;
            this.btnGN.Text = "G-N";
            this.btnGN.UseVisualStyleBackColor = true;
            this.btnGN.Click += new System.EventHandler(this.btnGN_Click);
            // 
            // btnOZ
            // 
            this.btnOZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOZ.Location = new System.Drawing.Point(183, 1);
            this.btnOZ.Name = "btnOZ";
            this.btnOZ.Size = new System.Drawing.Size(89, 43);
            this.btnOZ.TabIndex = 2;
            this.btnOZ.Text = "O-Z";
            this.btnOZ.UseVisualStyleBackColor = true;
            this.btnOZ.Click += new System.EventHandler(this.btnOZ_Click);
            // 
            // lblVP
            // 
            this.lblVP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVP.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblVP.Location = new System.Drawing.Point(0, 79);
            this.lblVP.Name = "lblVP";
            this.lblVP.Size = new System.Drawing.Size(284, 124);
            this.lblVP.TabIndex = 3;
            this.lblVP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(26, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(183, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblVP);
            this.Controls.Add(this.btnOZ);
            this.Controls.Add(this.btnGN);
            this.Controls.Add(this.btnAF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAF;
        private System.Windows.Forms.Button btnGN;
        private System.Windows.Forms.Button btnOZ;
        private System.Windows.Forms.Label lblVP;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button2;
    }
}

