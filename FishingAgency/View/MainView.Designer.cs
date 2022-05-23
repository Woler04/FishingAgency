namespace FishingAgency.View
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.dgvFishingAgency = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddShip = new System.Windows.Forms.Button();
            this.btnAddCatch = new System.Windows.Forms.Button();
            this.btnShowShips = new System.Windows.Forms.Button();
            this.btnShowUsers = new System.Windows.Forms.Button();
            this.txtWelcome = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishingAgency)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFishingAgency
            // 
            this.dgvFishingAgency.AllowUserToAddRows = false;
            this.dgvFishingAgency.AllowUserToDeleteRows = false;
            this.dgvFishingAgency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFishingAgency.Location = new System.Drawing.Point(12, 79);
            this.dgvFishingAgency.Name = "dgvFishingAgency";
            this.dgvFishingAgency.ReadOnly = true;
            this.dgvFishingAgency.Size = new System.Drawing.Size(744, 426);
            this.dgvFishingAgency.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(301, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(455, 48);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Fishing Agency ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddShip
            // 
            this.btnAddShip.Location = new System.Drawing.Point(763, 79);
            this.btnAddShip.Name = "btnAddShip";
            this.btnAddShip.Size = new System.Drawing.Size(106, 39);
            this.btnAddShip.TabIndex = 3;
            this.btnAddShip.Text = "Add Ship";
            this.btnAddShip.UseVisualStyleBackColor = true;
            this.btnAddShip.Click += new System.EventHandler(this.btnAddShip_Click);
            // 
            // btnAddCatch
            // 
            this.btnAddCatch.Location = new System.Drawing.Point(883, 79);
            this.btnAddCatch.Name = "btnAddCatch";
            this.btnAddCatch.Size = new System.Drawing.Size(106, 39);
            this.btnAddCatch.TabIndex = 4;
            this.btnAddCatch.Text = "Add Catch";
            this.btnAddCatch.UseVisualStyleBackColor = true;
            // 
            // btnShowShips
            // 
            this.btnShowShips.Location = new System.Drawing.Point(762, 453);
            this.btnShowShips.Name = "btnShowShips";
            this.btnShowShips.Size = new System.Drawing.Size(227, 23);
            this.btnShowShips.TabIndex = 5;
            this.btnShowShips.Text = "Show Ships";
            this.btnShowShips.UseVisualStyleBackColor = true;
            this.btnShowShips.Click += new System.EventHandler(this.btnShowSomeData_Click);
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.Location = new System.Drawing.Point(762, 482);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(227, 23);
            this.btnShowUsers.TabIndex = 6;
            this.btnShowUsers.Text = "Show Users";
            this.btnShowUsers.UseVisualStyleBackColor = true;
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowMoreData_Click);
            // 
            // txtWelcome
            // 
            this.txtWelcome.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.Location = new System.Drawing.Point(760, 9);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(238, 48);
            this.txtWelcome.TabIndex = 7;
            this.txtWelcome.Text = "Welcome, DefaultUser";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(763, 124);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 39);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(884, 124);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 39);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 521);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtWelcome);
            this.Controls.Add(this.btnShowUsers);
            this.Controls.Add(this.btnShowShips);
            this.Controls.Add(this.btnAddCatch);
            this.Controls.Add(this.btnAddShip);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvFishingAgency);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainView";
            this.Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishingAgency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFishingAgency;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddShip;
        private System.Windows.Forms.Button btnAddCatch;
        private System.Windows.Forms.Button btnShowShips;
        private System.Windows.Forms.Button btnShowUsers;
        private System.Windows.Forms.Label txtWelcome;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}