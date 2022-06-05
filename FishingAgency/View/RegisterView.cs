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
        RegistrationController regController;
        public RegisterView()
        {
            InitializeComponent();
            regController = new RegistrationController();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Utility.Validate(txtFullName.Text) ||
            Utility.Validate(txtUsername.Text) ||
            Utility.Validate(txtPassword.Text)||
            Utility.Validate(txtShipName.Text))
            {
                return;
            }

            string fullName = txtFullName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string shipName = txtShipName.Text;

            if (Utility.ValidateUsername(username))
            {
                MessageBox.Show("This username already exist");
                return;
            }

            if (regController.Register(fullName, username, password, shipName))
            {
                LoginViewSummoning();
            }
        }

        private void lblLoginQ_Click(object sender, EventArgs e)
        {
            LoginViewSummoning();
        }

        private void LoginViewSummoning()
        {
            LoginView form = new LoginView();
            Utility.SwitchingForms(this, form);
        }
    }
}