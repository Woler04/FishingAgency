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
        DeleteShipController deleteShipController;
        public static DeleteShipView instance = null;
        public DeleteShipView(MainView mainView)
        {
            if (instance == null)
            {
                InitializeComponent();
                deleteShipController = new DeleteShipController();
                instance = this;
            }

            this.FormClosed += new FormClosedEventHandler(FormClosed);
            void FormClosed(object sender, FormClosedEventArgs e)
            {
                mainView.btnShowShips_Click(null, null);
                instance = null;
            }
        }

        private void btnDeleteShip_Click(object sender, EventArgs e)
        {
            if (Utility.Validate(txtName.Text))
            {
                return;
            }

            deleteShipController.DeleteShip(txtName.Text);
            instance = null;
            this.Close();
        }
    }
}
