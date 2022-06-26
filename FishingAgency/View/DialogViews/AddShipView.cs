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
        AddShipController addShipController;
        public static AddShipView instance = null;

        public AddShipView() 
        {
            if (instance == null)
            {
                InitializeComponent();
                addShipController = new AddShipController();
                instance = this;
            }

            this.FormClosed += new FormClosedEventHandler(FormClosed);
            void FormClosed(object sender, FormClosedEventArgs e)
            {
                instance = null;
            }
        }

        public AddShipView(MainView mainView) : this()
        {
            this.FormClosed += new FormClosedEventHandler(FormClosedFromMain);
            void FormClosedFromMain(object sender, FormClosedEventArgs e)
            {
                mainView.btnShowShips_Click(null, null);
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

            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                FishingShip shipToCheck = fadb.FishingShips.Where(s => s.Name == txtName.Text).FirstOrDefault();
                if (shipToCheck != null)
                {
                    var res = MessageBox.Show($"Already existing ship.", "No ship?");
                    return;
                }
            }

            FishingShip shipToAdd = new FishingShip
            {
                Name = txtName.Text,
                LicenseExpiration = dtpLicense.Value,
                FuelUsage = (double)nudFuelConsumption.Value,
                isForHobby = cbIsHoby.Checked
            };

            addShipController.AddShip(shipToAdd);
            instance = null;
            this.Close();
        }
    }
}
