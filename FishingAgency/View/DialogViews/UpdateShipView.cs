﻿using FishingAgency.Controller;
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
        FishingAgencyController controller;
        public static UpdateShipView instance = null;
        public UpdateShipView()
        {
            if (instance == null)
            {
                InitializeComponent();
                controller = new FishingAgencyController();
                instance = this;
            }
        }

        private void btnUpdateShip_Click(object sender, EventArgs e)
        {
            controller.Update(txtName.Text, txtNewName.Text, dtpLicense.Value, cbIsHoby.Checked, (double)nudFuelConsumption.Value);
            instance = null;
            this.Close();
        }
    }
}
