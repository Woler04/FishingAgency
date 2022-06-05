namespace FishingAgency.View
{
    partial class UpdateShipView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateShipView));
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.btnAddShip = new System.Windows.Forms.Button();
            this.lblFuelConsumption = new System.Windows.Forms.Label();
            this.nudFuelConsumption = new System.Windows.Forms.NumericUpDown();
            this.cbIsHoby = new System.Windows.Forms.CheckBox();
            this.dtpLicense = new System.Windows.Forms.DateTimePicker();
            this.lblLicense = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblShipName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudFuelConsumption)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(15, 81);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(200, 18);
            this.txtNewName.TabIndex = 19;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewName.Location = new System.Drawing.Point(12, 62);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(137, 16);
            this.lblNewName.TabIndex = 18;
            this.lblNewName.Text = "New Ship name";
            // 
            // btnAddShip
            // 
            this.btnAddShip.Location = new System.Drawing.Point(12, 266);
            this.btnAddShip.Name = "btnAddShip";
            this.btnAddShip.Size = new System.Drawing.Size(203, 23);
            this.btnAddShip.TabIndex = 17;
            this.btnAddShip.Text = "Update Ship";
            this.btnAddShip.UseVisualStyleBackColor = true;
            this.btnAddShip.Click += new System.EventHandler(this.btnUpdateShip_Click);
            // 
            // lblFuelConsumption
            // 
            this.lblFuelConsumption.AutoSize = true;
            this.lblFuelConsumption.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelConsumption.Location = new System.Drawing.Point(12, 179);
            this.lblFuelConsumption.Name = "lblFuelConsumption";
            this.lblFuelConsumption.Size = new System.Drawing.Size(207, 16);
            this.lblFuelConsumption.TabIndex = 16;
            this.lblFuelConsumption.Text = "New Fuel consumption";
            // 
            // nudFuelConsumption
            // 
            this.nudFuelConsumption.DecimalPlaces = 2;
            this.nudFuelConsumption.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudFuelConsumption.Location = new System.Drawing.Point(15, 198);
            this.nudFuelConsumption.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudFuelConsumption.Name = "nudFuelConsumption";
            this.nudFuelConsumption.Size = new System.Drawing.Size(94, 18);
            this.nudFuelConsumption.TabIndex = 15;
            // 
            // cbIsHoby
            // 
            this.cbIsHoby.AutoSize = true;
            this.cbIsHoby.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsHoby.Location = new System.Drawing.Point(15, 240);
            this.cbIsHoby.Name = "cbIsHoby";
            this.cbIsHoby.Size = new System.Drawing.Size(136, 20);
            this.cbIsHoby.TabIndex = 14;
            this.cbIsHoby.Text = "is for Hoby";
            this.cbIsHoby.UseVisualStyleBackColor = true;
            // 
            // dtpLicense
            // 
            this.dtpLicense.Location = new System.Drawing.Point(15, 138);
            this.dtpLicense.Name = "dtpLicense";
            this.dtpLicense.Size = new System.Drawing.Size(200, 18);
            this.dtpLicense.TabIndex = 13;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.Location = new System.Drawing.Point(12, 119);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(217, 16);
            this.lblLicense.TabIndex = 12;
            this.lblLicense.Text = "New License Exp. Date";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 18);
            this.txtName.TabIndex = 11;
            // 
            // lblShipName
            // 
            this.lblShipName.AutoSize = true;
            this.lblShipName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipName.Location = new System.Drawing.Point(12, 9);
            this.lblShipName.Name = "lblShipName";
            this.lblShipName.Size = new System.Drawing.Size(97, 16);
            this.lblShipName.TabIndex = 10;
            this.lblShipName.Text = "Ship name";
            // 
            // UpdateShipView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(236, 306);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.lblNewName);
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
            this.Name = "UpdateShipView";
            this.ShowInTaskbar = false;
            this.Text = "Update ship";
            ((System.ComponentModel.ISupportInitialize)(this.nudFuelConsumption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Button btnAddShip;
        private System.Windows.Forms.Label lblFuelConsumption;
        private System.Windows.Forms.NumericUpDown nudFuelConsumption;
        private System.Windows.Forms.CheckBox cbIsHoby;
        private System.Windows.Forms.DateTimePicker dtpLicense;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblShipName;
    }
}