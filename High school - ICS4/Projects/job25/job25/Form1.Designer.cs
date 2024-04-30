namespace job25
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.rdo3 = new System.Windows.Forms.RadioButton();
            this.rdo4 = new System.Windows.Forms.RadioButton();
            this.rdo5 = new System.Windows.Forms.RadioButton();
            this.lblTeacherTitle = new System.Windows.Forms.Label();
            this.lblSubjectTitle = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo5);
            this.groupBox1.Controls.Add(this.rdo4);
            this.groupBox1.Controls.Add(this.rdo3);
            this.groupBox1.Controls.Add(this.rdo2);
            this.groupBox1.Controls.Add(this.rdo1);
            this.groupBox1.Location = new System.Drawing.Point(140, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Schedule";
            // 
            // rdo1
            // 
            this.rdo1.AutoSize = true;
            this.rdo1.Location = new System.Drawing.Point(0, 19);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(64, 17);
            this.rdo1.TabIndex = 0;
            this.rdo1.Text = "Period 1";
            this.rdo1.UseVisualStyleBackColor = true;
            this.rdo1.CheckedChanged += new System.EventHandler(this.rdo1_CheckedChanged);
            // 
            // rdo2
            // 
            this.rdo2.AutoSize = true;
            this.rdo2.Location = new System.Drawing.Point(0, 42);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(64, 17);
            this.rdo2.TabIndex = 1;
            this.rdo2.Text = "Period 2";
            this.rdo2.UseVisualStyleBackColor = true;
            this.rdo2.CheckedChanged += new System.EventHandler(this.rdo2_CheckedChanged);
            // 
            // rdo3
            // 
            this.rdo3.AutoSize = true;
            this.rdo3.Location = new System.Drawing.Point(0, 65);
            this.rdo3.Name = "rdo3";
            this.rdo3.Size = new System.Drawing.Size(64, 17);
            this.rdo3.TabIndex = 2;
            this.rdo3.Text = "Period 3";
            this.rdo3.UseVisualStyleBackColor = true;
            this.rdo3.CheckedChanged += new System.EventHandler(this.rdo3_CheckedChanged);
            // 
            // rdo4
            // 
            this.rdo4.AutoSize = true;
            this.rdo4.Location = new System.Drawing.Point(0, 88);
            this.rdo4.Name = "rdo4";
            this.rdo4.Size = new System.Drawing.Size(64, 17);
            this.rdo4.TabIndex = 3;
            this.rdo4.Text = "Period 4";
            this.rdo4.UseVisualStyleBackColor = true;
            this.rdo4.CheckedChanged += new System.EventHandler(this.rdo4_CheckedChanged);
            // 
            // rdo5
            // 
            this.rdo5.AutoSize = true;
            this.rdo5.Location = new System.Drawing.Point(0, 112);
            this.rdo5.Name = "rdo5";
            this.rdo5.Size = new System.Drawing.Size(64, 17);
            this.rdo5.TabIndex = 4;
            this.rdo5.Text = "Period 5";
            this.rdo5.UseVisualStyleBackColor = true;
            this.rdo5.CheckedChanged += new System.EventHandler(this.rdo5_CheckedChanged);
            // 
            // lblTeacherTitle
            // 
            this.lblTeacherTitle.AutoSize = true;
            this.lblTeacherTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTeacherTitle.Name = "lblTeacherTitle";
            this.lblTeacherTitle.Size = new System.Drawing.Size(47, 13);
            this.lblTeacherTitle.TabIndex = 1;
            this.lblTeacherTitle.Text = "Teacher";
            // 
            // lblSubjectTitle
            // 
            this.lblSubjectTitle.AutoSize = true;
            this.lblSubjectTitle.Location = new System.Drawing.Point(322, 9);
            this.lblSubjectTitle.Name = "lblSubjectTitle";
            this.lblSubjectTitle.Size = new System.Drawing.Size(43, 13);
            this.lblSubjectTitle.TabIndex = 2;
            this.lblSubjectTitle.Text = "Subject";
            // 
            // lblTeacher
            // 
            this.lblTeacher.BackColor = System.Drawing.Color.White;
            this.lblTeacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTeacher.Location = new System.Drawing.Point(12, 31);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(100, 23);
            this.lblTeacher.TabIndex = 3;
            // 
            // lblSubject
            // 
            this.lblSubject.BackColor = System.Drawing.Color.White;
            this.lblSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubject.Location = new System.Drawing.Point(265, 31);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(100, 23);
            this.lblSubject.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(290, 164);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 6;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 199);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.lblSubjectTitle);
            this.Controls.Add(this.lblTeacherTitle);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo1;
        private System.Windows.Forms.RadioButton rdo5;
        private System.Windows.Forms.RadioButton rdo4;
        private System.Windows.Forms.RadioButton rdo3;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.Label lblTeacherTitle;
        private System.Windows.Forms.Label lblSubjectTitle;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnd;
    }
}

