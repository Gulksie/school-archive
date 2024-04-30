namespace job33
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
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.chkSpeakers = new System.Windows.Forms.CheckBox();
            this.chkRouter = new System.Windows.Forms.CheckBox();
            this.chkMonitor = new System.Windows.Forms.CheckBox();
            this.chkPrinter = new System.Windows.Forms.CheckBox();
            this.grpShipping = new System.Windows.Forms.GroupBox();
            this.rdoPickup = new System.Windows.Forms.RadioButton();
            this.rdoDelivery = new System.Windows.Forms.RadioButton();
            this.lblSelectedTitle = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblTotalTile = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpAccessories.SuspendLayout();
            this.grpShipping.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(59, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Newman Comp";
            // 
            // grpAccessories
            // 
            this.grpAccessories.Controls.Add(this.chkSpeakers);
            this.grpAccessories.Controls.Add(this.chkRouter);
            this.grpAccessories.Controls.Add(this.chkMonitor);
            this.grpAccessories.Controls.Add(this.chkPrinter);
            this.grpAccessories.Location = new System.Drawing.Point(13, 41);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Size = new System.Drawing.Size(139, 138);
            this.grpAccessories.TabIndex = 1;
            this.grpAccessories.TabStop = false;
            this.grpAccessories.Text = "Accessories";
            // 
            // chkSpeakers
            // 
            this.chkSpeakers.AutoSize = true;
            this.chkSpeakers.Location = new System.Drawing.Point(7, 92);
            this.chkSpeakers.Name = "chkSpeakers";
            this.chkSpeakers.Size = new System.Drawing.Size(71, 17);
            this.chkSpeakers.TabIndex = 3;
            this.chkSpeakers.Text = "Speakers";
            this.chkSpeakers.UseVisualStyleBackColor = true;
            this.chkSpeakers.CheckedChanged += new System.EventHandler(this.chkSpeakers_CheckedChanged);
            // 
            // chkRouter
            // 
            this.chkRouter.AutoSize = true;
            this.chkRouter.Location = new System.Drawing.Point(7, 68);
            this.chkRouter.Name = "chkRouter";
            this.chkRouter.Size = new System.Drawing.Size(58, 17);
            this.chkRouter.TabIndex = 2;
            this.chkRouter.Text = "Router";
            this.chkRouter.UseVisualStyleBackColor = true;
            this.chkRouter.CheckedChanged += new System.EventHandler(this.chkRouter_CheckedChanged);
            // 
            // chkMonitor
            // 
            this.chkMonitor.AutoSize = true;
            this.chkMonitor.Location = new System.Drawing.Point(7, 44);
            this.chkMonitor.Name = "chkMonitor";
            this.chkMonitor.Size = new System.Drawing.Size(61, 17);
            this.chkMonitor.TabIndex = 1;
            this.chkMonitor.Text = "Monitor";
            this.chkMonitor.UseVisualStyleBackColor = true;
            this.chkMonitor.CheckedChanged += new System.EventHandler(this.chkMonitor_CheckedChanged);
            // 
            // chkPrinter
            // 
            this.chkPrinter.AutoSize = true;
            this.chkPrinter.Location = new System.Drawing.Point(7, 20);
            this.chkPrinter.Name = "chkPrinter";
            this.chkPrinter.Size = new System.Drawing.Size(56, 17);
            this.chkPrinter.TabIndex = 0;
            this.chkPrinter.Text = "Printer";
            this.chkPrinter.UseVisualStyleBackColor = true;
            this.chkPrinter.CheckedChanged += new System.EventHandler(this.chkPrinter_CheckedChanged);
            // 
            // grpShipping
            // 
            this.grpShipping.Controls.Add(this.rdoPickup);
            this.grpShipping.Controls.Add(this.rdoDelivery);
            this.grpShipping.Location = new System.Drawing.Point(158, 41);
            this.grpShipping.Name = "grpShipping";
            this.grpShipping.Size = new System.Drawing.Size(90, 87);
            this.grpShipping.TabIndex = 2;
            this.grpShipping.TabStop = false;
            // 
            // rdoPickup
            // 
            this.rdoPickup.AutoSize = true;
            this.rdoPickup.Checked = true;
            this.rdoPickup.Location = new System.Drawing.Point(7, 43);
            this.rdoPickup.Name = "rdoPickup";
            this.rdoPickup.Size = new System.Drawing.Size(58, 17);
            this.rdoPickup.TabIndex = 1;
            this.rdoPickup.TabStop = true;
            this.rdoPickup.Text = "Pickup";
            this.rdoPickup.UseVisualStyleBackColor = true;
            this.rdoPickup.CheckedChanged += new System.EventHandler(this.rdoPickup_CheckedChanged);
            // 
            // rdoDelivery
            // 
            this.rdoDelivery.AutoSize = true;
            this.rdoDelivery.Location = new System.Drawing.Point(7, 20);
            this.rdoDelivery.Name = "rdoDelivery";
            this.rdoDelivery.Size = new System.Drawing.Size(63, 17);
            this.rdoDelivery.TabIndex = 0;
            this.rdoDelivery.TabStop = true;
            this.rdoDelivery.Text = "Delivery";
            this.rdoDelivery.UseVisualStyleBackColor = true;
            this.rdoDelivery.CheckedChanged += new System.EventHandler(this.rdoDelivery_CheckedChanged);
            // 
            // lblSelectedTitle
            // 
            this.lblSelectedTitle.AutoSize = true;
            this.lblSelectedTitle.Location = new System.Drawing.Point(10, 182);
            this.lblSelectedTitle.Name = "lblSelectedTitle";
            this.lblSelectedTitle.Size = new System.Drawing.Size(109, 13);
            this.lblSelectedTitle.TabIndex = 3;
            this.lblSelectedTitle.Text = "Accessories Selected";
            // 
            // lblSelected
            // 
            this.lblSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelected.Location = new System.Drawing.Point(13, 199);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(235, 75);
            this.lblSelected.TabIndex = 4;
            // 
            // lblTotalTile
            // 
            this.lblTotalTile.AutoSize = true;
            this.lblTotalTile.Location = new System.Drawing.Point(10, 284);
            this.lblTotalTile.Name = "lblTotalTile";
            this.lblTotalTile.Size = new System.Drawing.Size(31, 13);
            this.lblTotalTile.TabIndex = 5;
            this.lblTotalTile.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(47, 284);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "$0";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 319);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(174, 319);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 354);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalTile);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lblSelectedTitle);
            this.Controls.Add(this.grpShipping);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.grpShipping.ResumeLayout(false);
            this.grpShipping.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.CheckBox chkSpeakers;
        private System.Windows.Forms.CheckBox chkRouter;
        private System.Windows.Forms.CheckBox chkMonitor;
        private System.Windows.Forms.CheckBox chkPrinter;
        private System.Windows.Forms.GroupBox grpShipping;
        private System.Windows.Forms.RadioButton rdoPickup;
        private System.Windows.Forms.RadioButton rdoDelivery;
        private System.Windows.Forms.Label lblSelectedTitle;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblTotalTile;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

