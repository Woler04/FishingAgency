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
    public partial class MainView : Form
    {
        private FishingAgencyController controller;

        public MainView()
        {
            InitializeComponent();
            controller = new FishingAgencyController();
            txtWelcome.Text = $"Welcome, {Utility.LoggedUser.Name}";
        }

        private void btnShowShips_Click(object sender, EventArgs e)
        {
            ResetColumns();
            dgvFishingAgency.DataSource = controller.GetFishingShips();

            dgvFishingAgency.Columns.Remove("Id");
            dgvFishingAgency.Columns.Remove("Catches");
            dgvFishingAgency.Columns.Remove("Users");

            dgvFishingAgency.Columns["Name"].Width = 200;
        }

        ///trqq da si pecahtaneto
        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            ResetColumns();
            dgvFishingAgency.DataSource = controller.GetUsers();

            dgvFishingAgency.Columns.Remove("Id");
            dgvFishingAgency.Columns.Remove("FishingShip");
            dgvFishingAgency.Columns.Remove("Password");
            dgvFishingAgency.Columns.Remove("Username");
            dgvFishingAgency.Columns.Remove("ShipId");

            dgvFishingAgency.Columns.Add("ShipName", "Current Ship");

            dgvFishingAgency.Columns["Name"].Width = 200;
            dgvFishingAgency.Columns["ShipName"].Width = 200;

            for (int i = 0; i < dgvFishingAgency.RowCount; i++)
            {
                dgvFishingAgency.Rows[i].Cells[1].Value = controller.GetShipsNames(controller.GetUsers()[i].Id - 1).ToString();
            }
        }

        private void btnShowCatchses_Click(object sender, EventArgs e)
        {
            ResetColumns();
            dgvFishingAgency.DataSource = controller.GetCatches();

            dgvFishingAgency.Columns.Remove("Id");
            dgvFishingAgency.Columns.Remove("ShipId");
            dgvFishingAgency.Columns.Remove("FishingShip");

            dgvFishingAgency.Columns.Add("ShipName", "Ship");

            for (int i = 0; i < dgvFishingAgency.RowCount; i++)
            {
                dgvFishingAgency.Rows[i].Cells[3].Value = controller.GetShipNameByCatch((Catch)dgvFishingAgency.Rows[i].DataBoundItem);
            }
        }

        private void ResetColumns()
        {
            dgvFishingAgency.DataSource = null;
            if (dgvFishingAgency.ColumnCount > 0)
            {
                for (int i = 0; i <= dgvFishingAgency.ColumnCount; i++)
                {
                    dgvFishingAgency.Columns.RemoveAt(i);
                }
            }  
        }

        //CRUD BUTTONS
        private void btnAddShip_Click(object sender, EventArgs e)
        {
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

        private void btnAddCatch_Click(object sender, EventArgs e)
        {
            if (AddCatchView.instance == null)
            {
                AddCatchView addCatch = new AddCatchView();
                addCatch.Show();
            }
        }
    }
}
