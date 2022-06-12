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
            this.btnDeleteShip = new System.Windows.Forms.Button();
            this.btnUpdateShip = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnShowCatches = new System.Windows.Forms.Button();
            this.btnUpdateCatch = new System.Windows.Forms.Button();
            this.btnDeleteCatch = new System.Windows.Forms.Button();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.btnShipLeaderboard = new System.Windows.Forms.Button();
            this.btnEnvPolution = new System.Windows.Forms.Button();
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
            this.btnAddCatch.Location = new System.Drawing.Point(763, 188);
            this.btnAddCatch.Name = "btnAddCatch";
            this.btnAddCatch.Size = new System.Drawing.Size(106, 39);
            this.btnAddCatch.TabIndex = 4;
            this.btnAddCatch.Text = "Add Catch";
            this.btnAddCatch.UseVisualStyleBackColor = true;
            this.btnAddCatch.Click += new System.EventHandler(this.btnAddCatch_Click);
            // 
            // btnShowShips
            // 
            this.btnShowShips.Location = new System.Drawing.Point(762, 453);
            this.btnShowShips.Name = "btnShowShips";
            this.btnShowShips.Size = new System.Drawing.Size(227, 23);
            this.btnShowShips.TabIndex = 5;
            this.btnShowShips.Text = "Show Ships";
            this.btnShowShips.UseVisualStyleBackColor = true;
            this.btnShowShips.Click += new System.EventHandler(this.btnShowShips_Click);
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.Location = new System.Drawing.Point(762, 482);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(227, 23);
            this.btnShowUsers.TabIndex = 6;
            this.btnShowUsers.Text = "Show Users";
            this.btnShowUsers.UseVisualStyleBackColor = true;
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowUsers_Click);
            // 
            // txtWelcome
            // 
            this.txtWelcome.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.Location = new System.Drawing.Point(12, 9);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(238, 40);
            this.txtWelcome.TabIndex = 7;
            this.txtWelcome.Text = "Welcome, DefaultUser";
            // 
            // btnDeleteShip
            // 
            this.btnDeleteShip.Location = new System.Drawing.Point(763, 124);
            this.btnDeleteShip.Name = "btnDeleteShip";
            this.btnDeleteShip.Size = new System.Drawing.Size(106, 39);
            this.btnDeleteShip.TabIndex = 8;
            this.btnDeleteShip.Text = "Delete Ship";
            this.btnDeleteShip.UseVisualStyleBackColor = true;
            this.btnDeleteShip.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateShip
            // 
            this.btnUpdateShip.Location = new System.Drawing.Point(884, 79);
            this.btnUpdateShip.Name = "btnUpdateShip";
            this.btnUpdateShip.Size = new System.Drawing.Size(105, 39);
            this.btnUpdateShip.TabIndex = 9;
            this.btnUpdateShip.Text = "Update Ship";
            this.btnUpdateShip.UseVisualStyleBackColor = true;
            this.btnUpdateShip.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(15, 50);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(227, 23);
            this.btnUpdateUser.TabIndex = 10;
            this.btnUpdateUser.Text = "Account Settings";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnShowCatches
            // 
            this.btnShowCatches.Location = new System.Drawing.Point(762, 424);
            this.btnShowCatches.Name = "btnShowCatches";
            this.btnShowCatches.Size = new System.Drawing.Size(227, 23);
            this.btnShowCatches.TabIndex = 11;
            this.btnShowCatches.Text = "Show Catches";
            this.btnShowCatches.UseVisualStyleBackColor = true;
            this.btnShowCatches.Click += new System.EventHandler(this.btnShowCatchses_Click);
            // 
            // btnUpdateCatch
            // 
            this.btnUpdateCatch.Location = new System.Drawing.Point(884, 188);
            this.btnUpdateCatch.Name = "btnUpdateCatch";
            this.btnUpdateCatch.Size = new System.Drawing.Size(105, 39);
            this.btnUpdateCatch.TabIndex = 12;
            this.btnUpdateCatch.Text = "Update Catch";
            this.btnUpdateCatch.UseVisualStyleBackColor = true;
            this.btnUpdateCatch.Click += new System.EventHandler(this.btnUpdateCatch_Click);
            // 
            // btnDeleteCatch
            // 
            this.btnDeleteCatch.Location = new System.Drawing.Point(762, 233);
            this.btnDeleteCatch.Name = "btnDeleteCatch";
            this.btnDeleteCatch.Size = new System.Drawing.Size(106, 39);
            this.btnDeleteCatch.TabIndex = 13;
            this.btnDeleteCatch.Text = "Delete Catch";
            this.btnDeleteCatch.UseVisualStyleBackColor = true;
            this.btnDeleteCatch.Click += new System.EventHandler(this.btnDeleteCatch_Click);
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.Location = new System.Drawing.Point(763, 366);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(227, 23);
            this.btnLeaderboard.TabIndex = 14;
            this.btnLeaderboard.Text = "Hobby Leaderboard";
            this.btnLeaderboard.UseVisualStyleBackColor = true;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // btnShipLeaderboard
            // 
            this.btnShipLeaderboard.Location = new System.Drawing.Point(762, 337);
            this.btnShipLeaderboard.Name = "btnShipLeaderboard";
            this.btnShipLeaderboard.Size = new System.Drawing.Size(227, 23);
            this.btnShipLeaderboard.TabIndex = 15;
            this.btnShipLeaderboard.Text = "Ships Leaderboard";
            this.btnShipLeaderboard.UseVisualStyleBackColor = true;
            this.btnShipLeaderboard.Click += new System.EventHandler(this.btnShipLeaderboard_Click);
            // 
            // btnEnvPolution
            // 
            this.btnEnvPolution.Location = new System.Drawing.Point(762, 308);
            this.btnEnvPolution.Name = "btnEnvPolution";
            this.btnEnvPolution.Size = new System.Drawing.Size(227, 23);
            this.btnEnvPolution.TabIndex = 16;
            this.btnEnvPolution.Text = "Env. Polution Check";
            this.btnEnvPolution.UseVisualStyleBackColor = true;
            this.btnEnvPolution.Click += new System.EventHandler(this.btnEnvPolution_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 521);
            this.Controls.Add(this.btnEnvPolution);
            this.Controls.Add(this.btnShipLeaderboard);
            this.Controls.Add(this.btnLeaderboard);
            this.Controls.Add(this.btnDeleteCatch);
            this.Controls.Add(this.btnUpdateCatch);
            this.Controls.Add(this.btnShowCatches);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnUpdateShip);
            this.Controls.Add(this.btnDeleteShip);
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
        private System.Windows.Forms.Button btnDeleteShip;
        private System.Windows.Forms.Button btnUpdateShip;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnShowCatches;
        private System.Windows.Forms.Button btnUpdateCatch;
        private System.Windows.Forms.Button btnDeleteCatch;
        private System.Windows.Forms.Button btnLeaderboard;
        private System.Windows.Forms.Button btnShipLeaderboard;
        private System.Windows.Forms.Button btnEnvPolution;
    }
}