namespace job07
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBox1 = new System.Windows.Forms.Label();
            this.lblBox2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAF
            // 
            this.btnAF.Location = new System.Drawing.Point(12, 26);
            this.btnAF.Name = "btnAF";
            this.btnAF.Size = new System.Drawing.Size(97, 23);
            this.btnAF.TabIndex = 0;
            this.btnAF.Text = "Mr. Macaluso";
            this.btnAF.UseVisualStyleBackColor = true;
            this.btnAF.Click += new System.EventHandler(this.btnAF_Click);
            // 
            // btnGN
            // 
            this.btnGN.Location = new System.Drawing.Point(12, 55);
            this.btnGN.Name = "btnGN";
            this.btnGN.Size = new System.Drawing.Size(97, 23);
            this.btnGN.TabIndex = 1;
            this.btnGN.Text = "Mr. Valeri";
            this.btnGN.UseVisualStyleBackColor = true;
            this.btnGN.Click += new System.EventHandler(this.btnGN_Click);
            // 
            // btnOZ
            // 
            this.btnOZ.Location = new System.Drawing.Point(12, 84);
            this.btnOZ.Name = "btnOZ";
            this.btnOZ.Size = new System.Drawing.Size(97, 23);
            this.btnOZ.TabIndex = 2;
            this.btnOZ.Text = "Mr. John";
            this.btnOZ.UseVisualStyleBackColor = true;
            this.btnOZ.Click += new System.EventHandler(this.btnOZ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Where to go when in trouble";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Box 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Box 2";
            // 
            // lblBox1
            // 
            this.lblBox1.BackColor = System.Drawing.Color.White;
            this.lblBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBox1.Location = new System.Drawing.Point(218, 45);
            this.lblBox1.Name = "lblBox1";
            this.lblBox1.Size = new System.Drawing.Size(216, 13);
            this.lblBox1.TabIndex = 6;
            // 
            // lblBox2
            // 
            this.lblBox2.BackColor = System.Drawing.Color.White;
            this.lblBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBox2.Location = new System.Drawing.Point(218, 75);
            this.lblBox2.Name = "lblBox2";
            this.lblBox2.Size = new System.Drawing.Size(216, 13);
            this.lblBox2.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(79, 118);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(240, 118);
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
            this.ClientSize = new System.Drawing.Size(446, 153);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblBox2);
            this.Controls.Add(this.lblBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOZ);
            this.Controls.Add(this.btnGN);
            this.Controls.Add(this.btnAF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAF;
        private System.Windows.Forms.Button btnGN;
        private System.Windows.Forms.Button btnOZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBox1;
        private System.Windows.Forms.Label lblBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

