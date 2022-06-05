namespace FishingAgency.View
{
    partial class AddCatchView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCatchView));
            this.lblLicense = new System.Windows.Forms.Label();
            this.dtpStartingDate = new System.Windows.Forms.DateTimePicker();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmaunt = new System.Windows.Forms.Label();
            this.btnAddCatch = new System.Windows.Forms.Button();
            this.lblCatchLenght = new System.Windows.Forms.Label();
            this.nudCatchLenght = new System.Windows.Forms.NumericUpDown();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.lblShipName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCatchLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.Location = new System.Drawing.Point(12, 9);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(137, 16);
            this.lblLicense.TabIndex = 2;
            this.lblLicense.Text = "Starting date";
            // 
            // dtpStartingDate
            // 
            this.dtpStartingDate.Location = new System.Drawing.Point(15, 28);
            this.dtpStartingDate.Name = "dtpStartingDate";
            this.dtpStartingDate.Size = new System.Drawing.Size(200, 18);
            this.dtpStartingDate.TabIndex = 3;
            // 
            // nudAmount
            // 
            this.nudAmount.DecimalPlaces = 2;
            this.nudAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudAmount.Location = new System.Drawing.Point(15, 77);
            this.nudAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(94, 18);
            this.nudAmount.TabIndex = 5;
            // 
            // lblAmaunt
            // 
            this.lblAmaunt.AutoSize = true;
            this.lblAmaunt.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmaunt.Location = new System.Drawing.Point(12, 58);
            this.lblAmaunt.Name = "lblAmaunt";
            this.lblAmaunt.Size = new System.Drawing.Size(67, 16);
            this.lblAmaunt.TabIndex = 6;
            this.lblAmaunt.Text = "Amount";
            // 
            // btnAddCatch
            // 
            this.btnAddCatch.Location = new System.Drawing.Point(12, 209);
            this.btnAddCatch.Name = "btnAddCatch";
            this.btnAddCatch.Size = new System.Drawing.Size(203, 23);
            this.btnAddCatch.TabIndex = 7;
            this.btnAddCatch.Text = "Add Catch";
            this.btnAddCatch.UseVisualStyleBackColor = true;
            this.btnAddCatch.Click += new System.EventHandler(this.btnAddCatch_Click);
            // 
            // lblCatchLenght
            // 
            this.lblCatchLenght.AutoSize = true;
            this.lblCatchLenght.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatchLenght.Location = new System.Drawing.Point(12, 110);
            this.lblCatchLenght.Name = "lblCatchLenght";
            this.lblCatchLenght.Size = new System.Drawing.Size(127, 16);
            this.lblCatchLenght.TabIndex = 9;
            this.lblCatchLenght.Text = "Catch Lenght";
            // 
            // nudCatchLenght
            // 
            this.nudCatchLenght.DecimalPlaces = 2;
            this.nudCatchLenght.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudCatchLenght.Location = new System.Drawing.Point(15, 129);
            this.nudCatchLenght.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCatchLenght.Name = "nudCatchLenght";
            this.nudCatchLenght.Size = new System.Drawing.Size(94, 18);
            this.nudCatchLenght.TabIndex = 8;
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(12, 176);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(200, 18);
            this.txtShipName.TabIndex = 13;
            // 
            // lblShipName
            // 
            this.lblShipName.AutoSize = true;
            this.lblShipName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipName.Location = new System.Drawing.Point(9, 157);
            this.lblShipName.Name = "lblShipName";
            this.lblShipName.Size = new System.Drawing.Size(97, 16);
            this.lblShipName.TabIndex = 12;
            this.lblShipName.Text = "Ship name";
            // 
            // AddCatchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(236, 244);
            this.Controls.Add(this.txtShipName);
            this.Controls.Add(this.lblShipName);
            this.Controls.Add(this.lblCatchLenght);
            this.Controls.Add(this.nudCatchLenght);
            this.Controls.Add(this.btnAddCatch);
            this.Controls.Add(this.lblAmaunt);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.dtpStartingDate);
            this.Controls.Add(this.lblLicense);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCatchView";
            this.ShowInTaskbar = false;
            this.Text = "Add catch";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCatchLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.DateTimePicker dtpStartingDate;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label lblAmaunt;
        private System.Windows.Forms.Button btnAddCatch;
        private System.Windows.Forms.Label lblCatchLenght;
        private System.Windows.Forms.NumericUpDown nudCatchLenght;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.Label lblShipName;
    }
}