using FishingAgency.Controller;
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
    public partial class MainView : Form
    {
        private FishingAgencyController controller;
        public MainView()
        {
            InitializeComponent();
            controller = new FishingAgencyController();
            txtWelcome.Text = $"Welcome, {controller.GetUsername()}";
        }

        private void btnAddShip_Click(object sender, EventArgs e)
        {
            //Open Form and enter params there get the params and set it to an object to be added into the db
        }

        private void btnShowSomeData_Click(object sender, EventArgs e)
        {
            dgvFishingAgency.DataSource = controller.GetFishingShips();
            dgvFishingAgency.Columns.Remove("Id");
            dgvFishingAgency.Columns.Remove("Catches");
            dgvFishingAgency.Columns.Remove("Users");
        }

        private void btnShowMoreData_Click(object sender, EventArgs e)
        {
            dgvFishingAgency.DataSource = controller.GetFishermans();
            dgvFishingAgency.Columns.Remove("Id");
            dgvFishingAgency.Columns.Remove("FishingShip");
            dgvFishingAgency.Columns.Remove("Name");
        }
    }
}
