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
        public AddShipView()
        {
            InitializeComponent();
            controller = new FishingAgencyController();
        }

        private void btnAddShip_Click(object sender, EventArgs e)
        {
            FishingShip shipToAdd = new FishingShip
            {
                Name = txtName.Text,
                LicenseExpiration = dtpLicense.Value,
                FuelUsage = (double)nudFuelConsumption.Value
            };
            controller.AddShip(shipToAdd);
            this.Close();
        }
    }
}
