namespace FishingAgency.View
{
    partial class UpdateCatchView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCatchView));
            this.btnUpdateCatch = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.dtpStartingDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartingDate = new System.Windows.Forms.Label();
            this.lblLenght = new System.Windows.Forms.Label();
            this.nudLenght = new System.Windows.Forms.NumericUpDown();
            this.lblShipName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateCatch
            // 
            this.btnUpdateCatch.Location = new System.Drawing.Point(15, 247);
            this.btnUpdateCatch.Name = "btnUpdateCatch";
            this.btnUpdateCatch.Size = new System.Drawing.Size(203, 23);
            this.btnUpdateCatch.TabIndex = 17;
            this.btnUpdateCatch.Text = "Update Catch";
            this.btnUpdateCatch.UseVisualStyleBackColor = true;
            this.btnUpdateCatch.Click += new System.EventHandler(this.btnUpdateShip_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(12, 124);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(67, 16);
            this.lblAmount.TabIndex = 16;
            this.lblAmount.Text = "Amount";
            // 
            // nudAmount
            // 
            this.nudAmount.DecimalPlaces = 2;
            this.nudAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudAmount.Location = new System.Drawing.Point(15, 143);
            this.nudAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(94, 18);
            this.nudAmount.TabIndex = 15;
            // 
            // dtpStartingDate
            // 
            this.dtpStartingDate.Location = new System.Drawing.Point(15, 83);
            this.dtpStartingDate.Name = "dtpStartingDate";
            this.dtpStartingDate.Size = new System.Drawing.Size(200, 18);
            this.dtpStartingDate.TabIndex = 13;
            // 
            // lblStartingDate
            // 
            this.lblStartingDate.AutoSize = true;
            this.lblStartingDate.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartingDate.Location = new System.Drawing.Point(12, 64);
            this.lblStartingDate.Name = "lblStartingDate";
            this.lblStartingDate.Size = new System.Drawing.Size(137, 16);
            this.lblStartingDate.TabIndex = 12;
            this.lblStartingDate.Text = "Starting Date";
            // 
            // lblLenght
            // 
            this.lblLenght.AutoSize = true;
            this.lblLenght.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLenght.Location = new System.Drawing.Point(12, 183);
            this.lblLenght.Name = "lblLenght";
            this.lblLenght.Size = new System.Drawing.Size(67, 16);
            this.lblLenght.TabIndex = 19;
            this.lblLenght.Text = "Lenght";
            // 
            // nudLenght
            // 
            this.nudLenght.DecimalPlaces = 2;
            this.nudLenght.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudLenght.Location = new System.Drawing.Point(15, 202);
            this.nudLenght.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudLenght.Name = "nudLenght";
            this.nudLenght.Size = new System.Drawing.Size(94, 18);
            this.nudLenght.TabIndex = 18;
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 18);
            this.txtName.TabIndex = 11;
            // 
            // UpdateCatchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(236, 282);
            this.Controls.Add(this.lblLenght);
            this.Controls.Add(this.nudLenght);
            this.Controls.Add(this.btnUpdateCatch);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.dtpStartingDate);
            this.Controls.Add(this.lblStartingDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblShipName);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateCatchView";
            this.ShowInTaskbar = false;
            this.Text = "Update ship";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateCatch;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.DateTimePicker dtpStartingDate;
        private System.Windows.Forms.Label lblStartingDate;
        private System.Windows.Forms.Label lblLenght;
        private System.Windows.Forms.NumericUpDown nudLenght;
        private System.Windows.Forms.Label lblShipName;
        private System.Windows.Forms.TextBox txtName;
    }
}