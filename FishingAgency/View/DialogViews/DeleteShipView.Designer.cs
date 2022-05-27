namespace FishingAgency.View
{
    partial class DeleteShipView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteShipView));
            this.lblShipName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDeleteShip = new System.Windows.Forms.Button();
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
            // btnDeleteShip
            // 
            this.btnDeleteShip.Location = new System.Drawing.Point(15, 52);
            this.btnDeleteShip.Name = "btnDeleteShip";
            this.btnDeleteShip.Size = new System.Drawing.Size(203, 23);
            this.btnDeleteShip.TabIndex = 7;
            this.btnDeleteShip.Text = "Delete Ship";
            this.btnDeleteShip.UseVisualStyleBackColor = true;
            this.btnDeleteShip.Click += new System.EventHandler(this.btnDeleteShip_Click);
            // 
            // DeleteShipView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(236, 90);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeleteShip);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblShipName);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DeleteShipView";
            this.ShowInTaskbar = false;
            this.Text = "Delete ship";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShipName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDeleteShip;
    }
}