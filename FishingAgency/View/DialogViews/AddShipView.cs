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
    public partial class AddShipView : Form
    {
        FishingAgencyController controller;
        public static AddShipView instance = null;
        public AddShipView()
        {
            if (instance == null)
            {
                InitializeComponent();
                controller = new FishingAgencyController();
                instance = this;
            }

            this.FormClosed += new FormClosedEventHandler(FormClosed);
            void FormClosed(object sender, FormClosedEventArgs e)
            {
                instance = null;
            }
        }

        private void btnAddShip_Click(object sender, EventArgs e)
        {
            if (Utility.Validate(txtName.Text) ||
            Utility.Validate(dtpLicense.Text) ||
            Utility.Validate(nudFuelConsumption.Value.ToString()))
            {
                return;
            }

            FishingShip shipToAdd = new FishingShip
            {
                Name = txtName.Text,
                LicenseExpiration = dtpLicense.Value,
                FuelUsage = (double)nudFuelConsumption.Value
            };

            controller.AddShip(shipToAdd);
            instance = null;
            this.Close();
        }
    }
}
