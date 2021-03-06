namespace FishingAgency.View
{
    partial class UpdateUserView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUserView));
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.txtShip = new System.Windows.Forms.TextBox();
            this.lblShip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(15, 81);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(200, 18);
            this.txtNewPassword.TabIndex = 19;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(12, 62);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(127, 16);
            this.lblNewPassword.TabIndex = 18;
            this.lblNewPassword.Text = "New Password";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(15, 259);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(203, 23);
            this.btnSaveChanges.TabIndex = 17;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnUpdateShip_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(15, 28);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 18);
            this.txtUsername.TabIndex = 11;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(12, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 16);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(15, 135);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(200, 18);
            this.txtOldPassword.TabIndex = 21;
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.Location = new System.Drawing.Point(12, 116);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(127, 16);
            this.lblOldPassword.TabIndex = 20;
            this.lblOldPassword.Text = "Old Password";
            // 
            // txtShip
            // 
            this.txtShip.Location = new System.Drawing.Point(15, 220);
            this.txtShip.Name = "txtShip";
            this.txtShip.Size = new System.Drawing.Size(200, 18);
            this.txtShip.TabIndex = 23;
            // 
            // lblShip
            // 
            this.lblShip.AutoSize = true;
            this.lblShip.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShip.Location = new System.Drawing.Point(12, 201);
            this.lblShip.Name = "lblShip";
            this.lblShip.Size = new System.Drawing.Size(47, 16);
            this.lblShip.TabIndex = 22;
            this.lblShip.Text = "Ship";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 11);
            this.label1.TabIndex = 24;
            this.label1.Text = "(if not sure check user data)";
            // 
            // UpdateUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(236, 294);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShip);
            this.Controls.Add(this.lblShip);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateUserView";
            this.ShowInTaskbar = false;
            this.Text = "Update ship";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.TextBox txtShip;
        private System.Windows.Forms.Label lblShip;
        private System.Windows.Forms.Label label1;
    }
}