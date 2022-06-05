namespace FishingAgency.View
{
    partial class AddShipView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddShipView));
            this.lblShipName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLicense = new System.Windows.Forms.Label();
            this.dtpLicense = new System.Windows.Forms.DateTimePicker();
            this.cbIsHoby = new System.Windows.Forms.CheckBox();
            this.nudFuelConsumption = new System.Windows.Forms.NumericUpDown();
            this.lblFuelConsumption = new System.Windows.Forms.Label();
            this.btnAddShip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFuelConsumption)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShipName
            // 
            this.lblShipName.AutoSize = true;
            this.lblShipName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipName.Location = new System.Drawing.Point(12, 9);
            this.lblShipName.Name = "lblShipName";
            this.lblShipName.Size = new System.Drawing.Size(97, 16);
            this.lblShipName.TabIndex = 0;
            this.lblShipName.Text = "Ship name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 18);
            this.txtName.TabIndex = 1;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.Location = new System.Drawing.Point(12, 62);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(177, 16);
            this.lblLicense.TabIndex = 2;
            this.lblLicense.Text = "License Exp. Date";
            // 
            // dtpLicense
            // 
            this.dtpLicense.Location = new System.Drawing.Point(15, 81);
            this.dtpLicense.Name = "dtpLicense";
            this.dtpLicense.Size = new System.Drawing.Size(200, 18);
            this.dtpLicense.TabIndex = 3;
            // 
            // cbIsHoby
            // 
            this.cbIsHoby.AutoSize = true;
            this.cbIsHoby.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsHoby.Location = new System.Drawing.Point(15, 183);
            this.cbIsHoby.Name = "cbIsHoby";
            this.cbIsHoby.Size = new System.Drawing.Size(136, 20);
            this.cbIsHoby.TabIndex = 4;
            this.cbIsHoby.Text = "is for Hoby";
            this.cbIsHoby.UseVisualStyleBackColor = true;
            // 
            // nudFuelConsumption
            // 
            this.nudFuelConsumption.DecimalPlaces = 2;
            this.nudFuelConsumption.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudFuelConsumption.Location = new System.Drawing.Point(15, 141);
            this.nudFuelConsumption.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudFuelConsumption.Name = "nudFuelConsumption";
            this.nudFuelConsumption.Size = new System.Drawing.Size(94, 18);
            this.nudFuelConsumption.TabIndex = 5;
            // 
            // lblFuelConsumption
            // 
            this.lblFuelConsumption.AutoSize = true;
            this.lblFuelConsumption.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelConsumption.Location = new System.Drawing.Point(12, 122);
            this.lblFuelConsumption.Name = "lblFuelConsumption";
            this.lblFuelConsumption.Size = new System.Drawing.Size(167, 16);
            this.lblFuelConsumption.TabIndex = 6;
            this.lblFuelConsumption.Text = "Fuel consumption";
            // 
            // btnAddShip
            // 
            this.btnAddShip.Location = new System.Drawing.Point(12, 209);
            this.btnAddShip.Name = "btnAddShip";
            this.btnAddShip.Size = new System.Drawing.Size(203, 23);
            this.btnAddShip.TabIndex = 7;
            this.btnAddShip.Text = "Add Ship";
            this.btnAddShip.UseVisualStyleBackColor = true;
            this.btnAddShip.Click += new System.EventHandler(this.btnAddShip_Click);
            // 
            // AddShipView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(236, 244);
            this.Controls.Add(this.btnAddShip);
            this.Controls.Add(this.lblFuelConsumption);
            this.Controls.Add(this.nudFuelConsumption);
            this.Controls.Add(this.cbIsHoby);
            this.Controls.Add(this.dtpLicense);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblShipName);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddShipView";
            this.ShowInTaskbar = false;
            this.Text = "Add ship";
            ((System.ComponentModel.ISupportInitialize)(this.nudFuelConsumption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShipName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.DateTimePicker dtpLicense;
        private System.Windows.Forms.CheckBox cbIsHoby;
        private System.Windows.Forms.NumericUpDown nudFuelConsumption;
        private System.Windows.Forms.Label lblFuelConsumption;
        private System.Windows.Forms.Button btnAddShip;
    }
}