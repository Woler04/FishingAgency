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
    public partial class UpdateUserView : Form
    {
        FishingAgencyController controller;
        RegistrationController regController;
        public static UpdateUserView instance = null;
        public UpdateUserView()
        {
            if (instance == null)
            {
                InitializeComponent();
                controller = new FishingAgencyController();
                regController = new RegistrationController();
                instance = this;

                txtUsername.Text = regController.GetLogedName();
            }
        }

        private void btnUpdateShip_Click(object sender, EventArgs e)
        {
            User newUser = new User()
            {
                Name = regController.GetLogedName(),
                Username = txtUsername.Text,
                Password = txtNewPassword.Text,
            };

            regController.UpdateUser(newUser, txtOldPassword.Text);
            instance = null;
            this.Close();
        }
    }
}
