namespace job27
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
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.rdoCupcake = new System.Windows.Forms.RadioButton();
            this.rdoCookie = new System.Windows.Forms.RadioButton();
            this.rdoCake = new System.Windows.Forms.RadioButton();
            this.picCake = new System.Windows.Forms.PictureBox();
            this.picCookie = new System.Windows.Forms.PictureBox();
            this.picCupcake = new System.Windows.Forms.PictureBox();
            this.lblItemTitle = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceTitle = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.grpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCookie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCupcake)).BeginInit();
            this.SuspendLayout();
            // 
            // grpItem
            // 
            this.grpItem.Controls.Add(this.rdoCake);
            this.grpItem.Controls.Add(this.rdoCookie);
            this.grpItem.Controls.Add(this.rdoCupcake);
            this.grpItem.Location = new System.Drawing.Point(12, 104);
            this.grpItem.Name = "grpItem";
            this.grpItem.Size = new System.Drawing.Size(131, 116);
            this.grpItem.TabIndex = 0;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "Item";
            // 
            // rdoCupcake
            // 
            this.rdoCupcake.AutoSize = true;
            this.rdoCupcake.Location = new System.Drawing.Point(7, 19);
            this.rdoCupcake.Name = "rdoCupcake";
            this.rdoCupcake.Size = new System.Drawing.Size(68, 17);
            this.rdoCupcake.TabIndex = 0;
            this.rdoCupcake.Text = "Cupcake";
            this.rdoCupcake.UseVisualStyleBackColor = true;
            this.rdoCupcake.CheckedChanged += new System.EventHandler(this.rdoCupcake_CheckedChanged);
            // 
            // rdoCookie
            // 
            this.rdoCookie.AutoSize = true;
            this.rdoCookie.Location = new System.Drawing.Point(7, 44);
            this.rdoCookie.Name = "rdoCookie";
            this.rdoCookie.Size = new System.Drawing.Size(58, 17);
            this.rdoCookie.TabIndex = 1;
            this.rdoCookie.Text = "Cookie";
            this.rdoCookie.UseVisualStyleBackColor = true;
            this.rdoCookie.CheckedChanged += new System.EventHandler(this.rdoCookie_CheckedChanged);
            // 
            // rdoCake
            // 
            this.rdoCake.AutoSize = true;
            this.rdoCake.Location = new System.Drawing.Point(7, 68);
            this.rdoCake.Name = "rdoCake";
            this.rdoCake.Size = new System.Drawing.Size(50, 17);
            this.rdoCake.TabIndex = 2;
            this.rdoCake.Text = "Cake";
            this.rdoCake.UseVisualStyleBackColor = true;
            this.rdoCake.CheckedChanged += new System.EventHandler(this.rdoCake_CheckedChanged);
            // 
            // picCake
            // 
            this.picCake.Image = global::job27.Properties.Resources.cake;
            this.picCake.Location = new System.Drawing.Point(186, 224);
            this.picCake.Name = "picCake";
            this.picCake.Size = new System.Drawing.Size(100, 85);
            this.picCake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCake.TabIndex = 3;
            this.picCake.TabStop = false;
            this.picCake.Visible = false;
            // 
            // picCookie
            // 
            this.picCookie.Image = global::job27.Properties.Resources.cookie;
            this.picCookie.Location = new System.Drawing.Point(186, 146);
            this.picCookie.Name = "picCookie";
            this.picCookie.Size = new System.Drawing.Size(100, 72);
            this.picCookie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCookie.TabIndex = 2;
            this.picCookie.TabStop = false;
            this.picCookie.Visible = false;
            // 
            // picCupcake
            // 
            this.picCupcake.Image = global::job27.Properties.Resources.cupcake;
            this.picCupcake.Location = new System.Drawing.Point(186, 39);
            this.picCupcake.Name = "picCupcake";
            this.picCupcake.Size = new System.Drawing.Size(100, 101);
            this.picCupcake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCupcake.TabIndex = 1;
            this.picCupcake.TabStop = false;
            this.picCupcake.Visible = false;
            // 
            // lblItemTitle
            // 
            this.lblItemTitle.AutoSize = true;
            this.lblItemTitle.Location = new System.Drawing.Point(328, 85);
            this.lblItemTitle.Name = "lblItemTitle";
            this.lblItemTitle.Size = new System.Drawing.Size(27, 13);
            this.lblItemTitle.TabIndex = 4;
            this.lblItemTitle.Text = "Item";
            this.lblItemTitle.Visible = false;
            // 
            // lblItem
            // 
            this.lblItem.BackColor = System.Drawing.Color.White;
            this.lblItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItem.Location = new System.Drawing.Point(331, 102);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(100, 23);
            this.lblItem.TabIndex = 5;
            this.lblItem.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(331, 172);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 23);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Visible = false;
            // 
            // lblPriceTitle
            // 
            this.lblPriceTitle.AutoSize = true;
            this.lblPriceTitle.Location = new System.Drawing.Point(328, 155);
            this.lblPriceTitle.Name = "lblPriceTitle";
            this.lblPriceTitle.Size = new System.Drawing.Size(31, 13);
            this.lblPriceTitle.TabIndex = 6;
            this.lblPriceTitle.Text = "Price";
            this.lblPriceTitle.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 328);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(344, 328);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 9;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 363);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPriceTitle);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblItemTitle);
            this.Controls.Add(this.picCake);
            this.Controls.Add(this.picCookie);
            this.Controls.Add(this.picCupcake);
            this.Controls.Add(this.grpItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpItem.ResumeLayout(false);
            this.grpItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCookie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCupcake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.RadioButton rdoCake;
        private System.Windows.Forms.RadioButton rdoCookie;
        private System.Windows.Forms.RadioButton rdoCupcake;
        private System.Windows.Forms.PictureBox picCupcake;
        private System.Windows.Forms.PictureBox picCookie;
        private System.Windows.Forms.PictureBox picCake;
        private System.Windows.Forms.Label lblItemTitle;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceTitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnd;
    }
}

