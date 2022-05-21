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
        public RegisterView()
        {
            InitializeComponent();
            controller = new FishingAgencyController();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string shipName = txtShipName.Text;

            controller.Register(fullName, username, password, shipName);

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