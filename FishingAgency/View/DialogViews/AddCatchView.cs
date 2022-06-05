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
    public partial class AddCatchView : Form
    {
        AddCatchController addCatchController;
        public static AddCatchView instance = null;
        public AddCatchView()
        {
            if (instance == null)
            {
                InitializeComponent();
                addCatchController = new AddCatchController();
                instance = this;
            }

            this.FormClosed += new FormClosedEventHandler(FormClosed);
            void FormClosed(object sender, FormClosedEventArgs e)
            {
                instance = null;
            }
        }

        private void btnAddCatch_Click(object sender, EventArgs e)
        {
            if (Utility.Validate(txtShipName.Text) ||
            Utility.Validate(dtpStartingDate.Value.ToString()) ||
            Utility.Validate(nudAmount.Value.ToString()) ||
            Utility.Validate(nudCatchLenght.Value.ToString()))
            {
                return;
            }

            string shipName = txtShipName.Text;
            Catch catchToAdd = new Catch
            {
                Lenght = (double)nudCatchLenght.Value,
                Amount = (double)nudAmount.Value,
                StartDate = dtpStartingDate.Value
            };

            addCatchController.AddCatch(catchToAdd, shipName);
            instance = null;
            this.Close();
        }
    }
}
