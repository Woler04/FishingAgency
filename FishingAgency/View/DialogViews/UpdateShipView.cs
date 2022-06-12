using FishingAgency.Controller;
using FishingAgency.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingAgency.View
{
    public partial class UpdateShipView : Form
    {
        UpdateShipController updateShipController;
        public static UpdateShipView instance = null;
        public UpdateShipView()
        {
            if (instance == null)
            {
                InitializeComponent();
                updateShipController = new UpdateShipController();
                instance = this;
            }

            this.FormClosed += new FormClosedEventHandler(FormClosed);
            void FormClosed(object sender, FormClosedEventArgs e)
            {
                instance = null;
            }
        }

        private void btnUpdateShip_Click(object sender, EventArgs e)
        {
            if (Utility.Validate(txtName.Text) ||
            Utility.Validate(dtpLicense.Text) ||
            Utility.Validate(nudFuelConsumption.Value.ToString()))
            {
                return;
            }

            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                FishingShip shipToCheck = fadb.FishingShips.Where(s => s.Name == txtNewName.Text).FirstOrDefault();
                if (shipToCheck != null)
                {
                    var res = MessageBox.Show($"Already existing ship.", "No ship?");
                    return;
                }
            }

            FishingShip newShip = new FishingShip()
            {
                Name = txtNewName.Text,
                LicenseExpiration = dtpLicense.Value,
                isForHobby = cbIsHoby.Checked,
                FuelUsage = (double)nudFuelConsumption.Value
            };
            if (String.IsNullOrEmpty(txtNewName.Text) || String.IsNullOrWhiteSpace(txtNewName.Text))
            {
                newShip.Name = txtName.Text;
            }

            updateShipController.UpdateShip(newShip, txtName.Text);
            instance = null;
            this.Close();
        }
    }
}
