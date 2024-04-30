namespace job21
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblFirstNameTitle = new System.Windows.Forms.Label();
            this.lblLastNameTitle = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(30, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WHAT IS YOUR NAME";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(35, 37);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(228, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Click here to continue";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblFirstNameTitle
            // 
            this.lblFirstNameTitle.AutoSize = true;
            this.lblFirstNameTitle.Location = new System.Drawing.Point(12, 95);
            this.lblFirstNameTitle.Name = "lblFirstNameTitle";
            this.lblFirstNameTitle.Size = new System.Drawing.Size(57, 13);
            this.lblFirstNameTitle.TabIndex = 2;
            this.lblFirstNameTitle.Text = "First Name";
            this.lblFirstNameTitle.Visible = false;
            // 
            // lblLastNameTitle
            // 
            this.lblLastNameTitle.AutoSize = true;
            this.lblLastNameTitle.Location = new System.Drawing.Point(214, 95);
            this.lblLastNameTitle.Name = "lblLastNameTitle";
            this.lblLastNameTitle.Size = new System.Drawing.Size(58, 13);
            this.lblLastNameTitle.TabIndex = 3;
            this.lblLastNameTitle.Text = "Last Name";
            this.lblLastNameTitle.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(12, 120);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(100, 23);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(185, 120);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(109, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(109, 227);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 7;
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
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastNameTitle);
            this.Controls.Add(this.lblFirstNameTitle);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblFirstNameTitle;
        private System.Windows.Forms.Label lblLastNameTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnd;
    }
}

