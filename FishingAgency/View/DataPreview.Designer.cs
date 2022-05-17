
namespace FishingAgency
{
    partial class DataPreview
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
            this.dgvFishingAgency = new System.Windows.Forms.DataGridView();
            this.btnShowShips = new System.Windows.Forms.Button();
            this.btnShowFishermans = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishingAgency)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFishingAgency
            // 
            this.dgvFishingAgency.AllowUserToAddRows = false;
            this.dgvFishingAgency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFishingAgency.Location = new System.Drawing.Point(12, 12);
            this.dgvFishingAgency.Name = "dgvFishingAgency";
            this.dgvFishingAgency.Size = new System.Drawing.Size(744, 426);
            this.dgvFishingAgency.TabIndex = 0;
            // 
            // btnShowShips
            // 
            this.btnShowShips.Location = new System.Drawing.Point(801, 12);
            this.btnShowShips.Name = "btnShowShips";
            this.btnShowShips.Size = new System.Drawing.Size(236, 76);
            this.btnShowShips.TabIndex = 1;
            this.btnShowShips.Text = "Ship List";
            this.btnShowShips.UseVisualStyleBackColor = true;
            this.btnShowShips.Click += new System.EventHandler(this.btnShowShips_Click);
            // 
            // btnShowFishermans
            // 
            this.btnShowFishermans.Location = new System.Drawing.Point(801, 94);
            this.btnShowFishermans.Name = "btnShowFishermans";
            this.btnShowFishermans.Size = new System.Drawing.Size(236, 76);
            this.btnShowFishermans.TabIndex = 2;
            this.btnShowFishermans.Text = "Fisherman List";
            this.btnShowFishermans.UseVisualStyleBackColor = true;
            this.btnShowFishermans.Click += new System.EventHandler(this.btnShowFishermans_Click);
            // 
            // Placeholder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1074, 450);
            this.Controls.Add(this.btnShowFishermans);
            this.Controls.Add(this.btnShowShips);
            this.Controls.Add(this.dgvFishingAgency);
            this.Name = "Placeholder";
            this.Text = "Placeholder";
            this.Load += new System.EventHandler(this.Placeholder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishingAgency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFishingAgency;
        private System.Windows.Forms.Button btnShowShips;
        private System.Windows.Forms.Button btnShowFishermans;
    }
}