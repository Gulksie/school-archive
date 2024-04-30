namespace ICS1
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.btnCountry = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.btnOlympic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            // lblMain
            // 
            this.lblMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMain.Location = new System.Drawing.Point(12, 38);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(260, 186);
            this.lblMain.TabIndex = 3;
            // 
            // btnCountry
            // 
            this.btnCountry.Location = new System.Drawing.Point(12, 12);
            this.btnCountry.Name = "btnCountry";
            this.btnCountry.Size = new System.Drawing.Size(75, 23);
            this.btnCountry.TabIndex = 4;
            this.btnCountry.Text = "Country";
            this.btnCountry.UseVisualStyleBackColor = true;
            this.btnCountry.Click += new System.EventHandler(this.btnCountry_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.Location = new System.Drawing.Point(104, 12);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(75, 23);
            this.btnMovies.TabIndex = 5;
            this.btnMovies.Text = "Movies";
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // btnOlympic
            // 
            this.btnOlympic.Location = new System.Drawing.Point(196, 12);
            this.btnOlympic.Name = "btnOlympic";
            this.btnOlympic.Size = new System.Drawing.Size(75, 23);
            this.btnOlympic.TabIndex = 6;
            this.btnOlympic.Text = "Olympic";
            this.btnOlympic.UseVisualStyleBackColor = true;
            this.btnOlympic.Click += new System.EventHandler(this.btnOlympic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnOlympic);
            this.Controls.Add(this.btnMovies);
            this.Controls.Add(this.btnCountry);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnCountry;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Button btnOlympic;
    }
}

