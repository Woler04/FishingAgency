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
using FishingAgency.View.DialogViews;

namespace FishingAgency.View
{
    public partial class LoginView : Form
    {
        FishingAgencyController controller;
        RegistrationController regController;

        public LoginView()
        {
            InitializeComponent();
            controller = new FishingAgencyController();
            regController = new RegistrationController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (regController.Validate(txtUsername.Text) ||
            regController.Validate(txtPassword.Text))
            {
                return;
            }

            if (regController.Login(username, password))
            {
                controller.SwitchingForms(this, new MainView());
                return;
            }
            else
            {
                var res = MessageBox.Show($"There is not such user. Want to create an account?", "No Account?", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    controller.SwitchingForms(this, new RegisterView());
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            controller.SwitchingForms(this, new RegisterView());
        }

        private void lblForgottenPassword_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Sucks to be you", "You forgor?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ForgottenPasswordView youForgor = new ForgottenPasswordView();
            youForgor.Show();
        }

    }
}