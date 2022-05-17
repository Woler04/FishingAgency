using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FishingAgency.Controller;

namespace FishingAgency
{
    public partial class DataPreview : Form
    {
        private FishingAgencyController controller;

        public DataPreview()
        {
            InitializeComponent();
            controller = new FishingAgencyController();
        }

        private void Placeholder_Load(object sender, EventArgs e)
        {
            //dgvFishingAgency.DataSource = controller.GetFishingShips();
        }

        private void btnShowShips_Click(object sender, EventArgs e)
        {
            dgvFishingAgency.DataSource = controller.GetFishingShips();
            dgvFishingAgency.Columns.Remove("Catches");
            dgvFishingAgency.Columns.Remove("Users");
        }

        private void btnShowFishermans_Click(object sender, EventArgs e)
        {
            dgvFishingAgency.DataSource = controller.GetFishermans();
            dgvFishingAgency.Columns.Remove("FishingShip");
        }
    }
}
