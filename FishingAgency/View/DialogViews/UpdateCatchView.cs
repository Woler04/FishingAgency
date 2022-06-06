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
    public partial class UpdateCatchView : Form
    {
        UpdateCatchControler updateCatchController;
        public static UpdateCatchView instance = null;
        private Catch catchTUPD;

        public UpdateCatchView(Catch catchTUPD)
        {
            if (instance == null)
            {
                InitializeComponent();
                dtpStartingDate.Value = catchTUPD.StartDate;
                updateCatchController = new UpdateCatchControler();
                instance = this;
            }

            this.FormClosed += new FormClosedEventHandler(FormClosed);
            void FormClosed(object sender, FormClosedEventArgs e)
            {
                instance = null;
            }
        }

        private void btnUpdateShip_Click(object sender, EventArgs e)
        {
            if (Utility.Validate(txtName.Text) ||
            Utility.Validate(dtpStartingDate.Text) ||
            Utility.Validate(nudLenght.Value.ToString()) ||
            Utility.Validate(nudAmount.Value.ToString()))
            {
                return;
            }

            Catch catchToUpdate = new Catch()
            {
                Lenght = (double)nudLenght.Value,
                Amount = (double)nudAmount.Value,
                StartDate = dtpStartingDate.Value
            };

            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                FishingShip shipToCheck = fadb.FishingShips.Where(s => s.Name == txtName.Text).FirstOrDefault();
                if (shipToCheck == null)
                {
                    var res = MessageBox.Show($"There is not such ship.", "No ship?");
                    return;
                }
                catchToUpdate.FishingShip = shipToCheck;
            }

            updateCatchController.UpdateCatch(catchToUpdate, txtName.Text, catchTUPD);
            instance = null;
            this.Close();
        }
    }
}
