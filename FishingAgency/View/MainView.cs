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
        private RegistrationController regController;

        public MainView()
        {
            InitializeComponent();
            controller = new FishingAgencyController();
            regController = new RegistrationController();

            txtWelcome.Text = $"Welcome, {Utility.LoggedUser.Name}";
        }

        private void btnShowSomeData_Click(object sender, EventArgs e)
        {
            dgvFishingAgency.DataSource = controller.GetFishingShips();
            dgvFishingAgency.Columns.Remove("Id");
            dgvFishingAgency.Columns.Remove("Catches");
            dgvFishingAgency.Columns.Remove("Users");
            if(dgvFishingAgency.Columns.Contains("ShipName"))
            { 
            dgvFishingAgency.Columns.Remove("ShipName");
            }
        }

        private void btnShowMoreData_Click(object sender, EventArgs e)
        {
            dgvFishingAgency.DataSource = controller.GetUsers();
            dgvFishingAgency.Columns.Remove("Id");
            dgvFishingAgency.Columns.Remove("Password");
            dgvFishingAgency.Columns.Remove("FishingShip");
            dgvFishingAgency.Columns.Remove("Username");
            dgvFishingAgency.Columns.Remove("ShipId");
            dgvFishingAgency.Columns.Add("ShipName", "Current Ship");
            dgvFishingAgency.Columns["ShipName"].Width = 200;
            dgvFishingAgency.Columns["Name"].Width = 200;

            for (int i = 0; i < dgvFishingAgency.RowCount; i++)
            {
                dgvFishingAgency.Rows[i].Cells[1].Value = controller.GetShip(controller.GetUsers()[i].Id-1).Name;
            }
        }

        private void btnAddShip_Click(object sender, EventArgs e)
        {
            //Open Form and enter params there get the params and set it to an object to be added into the db
            if (AddShipView.instance == null)
            {
                AddShipView addShip = new AddShipView();
                addShip.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeleteShipView.instance == null)
            {
                DeleteShipView deleteShip = new DeleteShipView();
                deleteShip.Show();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (UpdateShipView.instance == null)
            {
                UpdateShipView addShip = new UpdateShipView();
                addShip.Show();
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (UpdateUserView.instance == null)
            {
                UpdateUserView updateUser = new UpdateUserView();
                updateUser.Show();
            }
        }

    }
}
