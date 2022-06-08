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
        private Timer myTimer;
        private FishingAgencyController controller;
        private DgvState dgvState;
        private enum DgvState
        {
            Query1,
            Query2,
            Query3,
            Query4,
            Users,
            Ships,
            Catches
        };

        public MainView()
        {
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 1;
            myTimer.Start();
            dgvState = DgvState.Users;
            InitializeComponent();
            controller = new FishingAgencyController();
            txtWelcome.Text = $"Welcome, {Utility.LoggedUser.Name}";
            dgvFishingAgency.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvFishingAgency.MultiSelect = false;
        }

        private void btnShowShips_Click(object sender, EventArgs e)
        { 
            ResetColumns();
            dgvState = DgvState.Ships;
            myTimer.Start();

            dgvFishingAgency.DataSource = controller.GetFishingShips();
            dgvFishingAgency.CurrentCell = null;

            dgvFishingAgency.Columns.Remove("Id");
            dgvFishingAgency.Columns.Remove("Catches");
            dgvFishingAgency.Columns.Remove("Users");

            dgvFishingAgency.Columns["Name"].Width = 200;

            dgvFishingAgency.Columns.Add("CatchCount", "Catch Count");

            for (int i = 0; i < dgvFishingAgency.RowCount; i++)
            {
                dgvFishingAgency.Rows[i].Cells[4].Value = controller.GetCatchCountByShip((FishingShip)dgvFishingAgency.Rows[i].DataBoundItem); ;
            }
        }

        ///trqq da si pecahtaneto
        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            ResetColumns();
            dgvState = DgvState.Users;
            myTimer.Start();

            dgvFishingAgency.DataSource = controller.GetUsers();
            dgvFishingAgency.CurrentCell = null;

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
                if (dgvFishingAgency.Rows[i].Cells["Name"].Value as string == Utility.LoggedUser.Name)
                {
                    dgvFishingAgency.Rows[i].DefaultCellStyle.BackColor = Color.DarkBlue;
                    dgvFishingAgency.Rows[i].DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                }
            }
        }

        private void btnShowCatchses_Click(object sender, EventArgs e)
        {
            ResetColumns();
            dgvState = DgvState.Catches;

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
            dgvFishingAgency.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvFishingAgency.MultiSelect = false;
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

        private void btnUpdateCatch_Click(object sender, EventArgs e)
        {
            if (UpdateCatchView.instance == null)
            {
                Catch ctch;
                if (dgvFishingAgency.CurrentRow != null)
                {
                    try
                    {
                        ctch = (Catch)dgvFishingAgency.CurrentRow.DataBoundItem;
                    }
                    catch
                    {
                        MessageBox.Show("Please select row from \"Catch\" table");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please select row from \"Catch\" table");
                    return;
                }

                UpdateCatchView updateCatch = new UpdateCatchView(ctch);
                updateCatch.Show();
            }
        }

        private void btnDeleteCatch_Click(object sender, EventArgs e)
        {
            Catch ctch;
            if (dgvFishingAgency.CurrentRow != null)
            {
                try
                {
                    ctch = (Catch)dgvFishingAgency.CurrentRow.DataBoundItem;
                }
                catch
                {
                    MessageBox.Show("Please select row from \"Catch\" table");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select row from \"Catch\" table");
                return;
            }

            var res = MessageBox.Show($"Are you sure?", "Delete Catch?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                DeleteCatchController.DeleteCatch(ctch);
            }
        }

        private void TimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            switch (dgvState)
            {
                case DgvState.Query1:
                    //TBA
                    break;

                case DgvState.Query2:
                    btnLeaderboard_Click(null, null);
                    dgvFishingAgency.CurrentCell = null;
                    break;

                case DgvState.Query3:
                    //TBA
                    break;

                case DgvState.Query4:
                    //TBA
                    break;

                case DgvState.Users:
                    btnShowUsers_Click(null, null);
                    dgvFishingAgency.CurrentCell = null;
                    break;

                case DgvState.Ships:
                    btnShowShips_Click(null, null);
                    dgvFishingAgency.CurrentCell = null;
                    break;

                case DgvState.Catches:
                    btnShowCatchses_Click(null, null);
                    myTimer.Stop();
                    break;

                default:
                    Utility.Error16();
                    break;
            }
        }

        //Queries
        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            ResetColumns();
            dgvState = DgvState.Query2;
            myTimer.Start();

            dgvFishingAgency.DataSource = controller.GetHobbyLeaderBoard().ToList();

            dgvFishingAgency.Columns[0].Name = "Name";
            dgvFishingAgency.Columns[1].Name = "Amount Catched";
            for (int i = 0; i < dgvFishingAgency.RowCount; i++)
            {
                if (dgvFishingAgency.Rows[i].Cells["Name"].Value as string == Utility.LoggedUser.Name)
                {
                    dgvFishingAgency.Rows[i].DefaultCellStyle.BackColor = Color.DarkBlue;
                    dgvFishingAgency.Rows[i].DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                }
            }

            dgvFishingAgency.CurrentCell = null;
        }

        private void btnShipLeaderboard_Click(object sender, EventArgs e)
        {
            //testing purpeses
            MessageBox.Show(dgvState.ToString());
        }
    }
}
