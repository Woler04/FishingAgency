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
    public partial class DeleteShipView : Form
    {
        FishingAgencyController controller;
        public static DeleteShipView instance = null;
        public DeleteShipView()
        {
            if (instance == null)
            {
                InitializeComponent();
                controller = new FishingAgencyController();
                instance = this;
            }
        }

        private void btnDeleteShip_Click(object sender, EventArgs e)
        {
            controller.DeleteShip(txtName.Text);
            instance = null;
            this.Close();
        }
    }
}
