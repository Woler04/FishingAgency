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

namespace FishingAgency.View
{
    public partial class RegisterView : Form
    {
        FishingAgencyController controller;
        RegistrationController regController;
        public RegisterView()
        {
            InitializeComponent();
            controller = new FishingAgencyController();
            regController = new RegistrationController();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (regController.Validate(txtFullName.Text) ||
            regController.Validate(txtUsername.Text) ||
            regController.Validate(txtPassword.Text) ||
            regController.Validate(txtShipName.Text))
            {
                return;
            }

            string fullName = txtFullName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string shipName = txtShipName.Text;

            if (controller.ValidateUsername(username))
            {
                MessageBox.Show("This username already exist");
                return;
            }

            regController.Register(fullName, username, password, shipName);

            LoginViewSummoning();
        }

        private void lblLoginQ_Click(object sender, EventArgs e)
        {
            LoginViewSummoning();
        }

        private void LoginViewSummoning()
        {
            LoginView form = new LoginView();
            controller.SwitchingForms(this, form);
        }
    }
}