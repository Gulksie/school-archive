namespace assign2a
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
            this.grpDestination = new System.Windows.Forms.GroupBox();
            this.rdoAruba = new System.Windows.Forms.RadioButton();
            this.rdoBarbados = new System.Windows.Forms.RadioButton();
            this.rdoJamaica = new System.Windows.Forms.RadioButton();
            this.grpTemperatures = new System.Windows.Forms.GroupBox();
            this.rdoDecember = new System.Windows.Forms.RadioButton();
            this.rdoNovember = new System.Windows.Forms.RadioButton();
            this.rdoOctober = new System.Windows.Forms.RadioButton();
            this.picJamaica = new System.Windows.Forms.PictureBox();
            this.picBarbados = new System.Windows.Forms.PictureBox();
            this.picAruba = new System.Windows.Forms.PictureBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.grpDestination.SuspendLayout();
            this.grpTemperatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picJamaica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarbados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAruba)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDestination
            // 
            this.grpDestination.Controls.Add(this.rdoAruba);
            this.grpDestination.Controls.Add(this.rdoBarbados);
            this.grpDestination.Controls.Add(this.rdoJamaica);
            this.grpDestination.Location = new System.Drawing.Point(12, 26);
            this.grpDestination.Name = "grpDestination";
            this.grpDestination.Size = new System.Drawing.Size(89, 114);
            this.grpDestination.TabIndex = 0;
            this.grpDestination.TabStop = false;
            this.grpDestination.Text = "Destination";
            // 
            // rdoAruba
            // 
            this.rdoAruba.AutoSize = true;
            this.rdoAruba.Location = new System.Drawing.Point(6, 92);
            this.rdoAruba.Name = "rdoAruba";
            this.rdoAruba.Size = new System.Drawing.Size(53, 17);
            this.rdoAruba.TabIndex = 2;
            this.rdoAruba.Text = "Aruba";
            this.rdoAruba.UseVisualStyleBackColor = true;
            this.rdoAruba.CheckedChanged += new System.EventHandler(this.changeRdo);
            // 
            // rdoBarbados
            // 
            this.rdoBarbados.AutoSize = true;
            this.rdoBarbados.Location = new System.Drawing.Point(6, 68);
            this.rdoBarbados.Name = "rdoBarbados";
            this.rdoBarbados.Size = new System.Drawing.Size(70, 17);
            this.rdoBarbados.TabIndex = 1;
            this.rdoBarbados.Text = "Barbados";
            this.rdoBarbados.UseVisualStyleBackColor = true;
            this.rdoBarbados.CheckedChanged += new System.EventHandler(this.changeRdo);
            // 
            // rdoJamaica
            // 
            this.rdoJamaica.AutoSize = true;
            this.rdoJamaica.Location = new System.Drawing.Point(6, 44);
            this.rdoJamaica.Name = "rdoJamaica";
            this.rdoJamaica.Size = new System.Drawing.Size(64, 17);
            this.rdoJamaica.TabIndex = 0;
            this.rdoJamaica.Text = "Jamaica";
            this.rdoJamaica.UseVisualStyleBackColor = true;
            this.rdoJamaica.CheckedChanged += new System.EventHandler(this.changeRdo);
            // 
            // grpTemperatures
            // 
            this.grpTemperatures.Controls.Add(this.rdoDecember);
            this.grpTemperatures.Controls.Add(this.rdoNovember);
            this.grpTemperatures.Controls.Add(this.rdoOctober);
            this.grpTemperatures.Location = new System.Drawing.Point(122, 26);
            this.grpTemperatures.Name = "grpTemperatures";
            this.grpTemperatures.Size = new System.Drawing.Size(89, 114);
            this.grpTemperatures.TabIndex = 3;
            this.grpTemperatures.TabStop = false;
            this.grpTemperatures.Text = "Average Daily Temperature";
            // 
            // rdoDecember
            // 
            this.rdoDecember.AutoSize = true;
            this.rdoDecember.Location = new System.Drawing.Point(7, 91);
            this.rdoDecember.Name = "rdoDecember";
            this.rdoDecember.Size = new System.Drawing.Size(74, 17);
            this.rdoDecember.TabIndex = 2;
            this.rdoDecember.Text = "December";
            this.rdoDecember.UseVisualStyleBackColor = true;
            this.rdoDecember.CheckedChanged += new System.EventHandler(this.changeRdo);
            // 
            // rdoNovember
            // 
            this.rdoNovember.AutoSize = true;
            this.rdoNovember.Location = new System.Drawing.Point(7, 68);
            this.rdoNovember.Name = "rdoNovember";
            this.rdoNovember.Size = new System.Drawing.Size(74, 17);
            this.rdoNovember.TabIndex = 1;
            this.rdoNovember.Text = "November";
            this.rdoNovember.UseVisualStyleBackColor = true;
            this.rdoNovember.CheckedChanged += new System.EventHandler(this.changeRdo);
            // 
            // rdoOctober
            // 
            this.rdoOctober.AutoSize = true;
            this.rdoOctober.Location = new System.Drawing.Point(6, 44);
            this.rdoOctober.Name = "rdoOctober";
            this.rdoOctober.Size = new System.Drawing.Size(63, 17);
            this.rdoOctober.TabIndex = 0;
            this.rdoOctober.Text = "October";
            this.rdoOctober.UseVisualStyleBackColor = true;
            this.rdoOctober.CheckedChanged += new System.EventHandler(this.changeRdo);
            // 
            // picJamaica
            // 
            this.picJamaica.Image = global::assign2a.Properties.Resources.jamaica;
            this.picJamaica.Location = new System.Drawing.Point(231, 12);
            this.picJamaica.Name = "picJamaica";
            this.picJamaica.Size = new System.Drawing.Size(248, 159);
            this.picJamaica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJamaica.TabIndex = 4;
            this.picJamaica.TabStop = false;
            this.picJamaica.Visible = false;
            // 
            // picBarbados
            // 
            this.picBarbados.Image = global::assign2a.Properties.Resources.barbados_copy;
            this.picBarbados.Location = new System.Drawing.Point(231, 12);
            this.picBarbados.Name = "picBarbados";
            this.picBarbados.Size = new System.Drawing.Size(248, 159);
            this.picBarbados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBarbados.TabIndex = 5;
            this.picBarbados.TabStop = false;
            this.picBarbados.Visible = false;
            // 
            // picAruba
            // 
            this.picAruba.Image = global::assign2a.Properties.Resources.Aruba;
            this.picAruba.Location = new System.Drawing.Point(231, 12);
            this.picAruba.Name = "picAruba";
            this.picAruba.Size = new System.Drawing.Size(248, 159);
            this.picAruba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAruba.TabIndex = 6;
            this.picAruba.TabStop = false;
            this.picAruba.Visible = false;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(506, 72);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(0, 42);
            this.lblTemperature.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 183);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.picAruba);
            this.Controls.Add(this.picBarbados);
            this.Controls.Add(this.picJamaica);
            this.Controls.Add(this.grpTemperatures);
            this.Controls.Add(this.grpDestination);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpDestination.ResumeLayout(false);
            this.grpDestination.PerformLayout();
            this.grpTemperatures.ResumeLayout(false);
            this.grpTemperatures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picJamaica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarbados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAruba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDestination;
        private System.Windows.Forms.RadioButton rdoAruba;
        private System.Windows.Forms.RadioButton rdoBarbados;
        private System.Windows.Forms.RadioButton rdoJamaica;
        private System.Windows.Forms.GroupBox grpTemperatures;
        private System.Windows.Forms.RadioButton rdoDecember;
        private System.Windows.Forms.RadioButton rdoNovember;
        private System.Windows.Forms.RadioButton rdoOctober;
        private System.Windows.Forms.PictureBox picJamaica;
        private System.Windows.Forms.PictureBox picBarbados;
        private System.Windows.Forms.PictureBox picAruba;
        private System.Windows.Forms.Label lblTemperature;
    }
}

