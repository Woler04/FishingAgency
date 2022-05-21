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
    public partial class LoginView : Form
    {
        FishingAgencyController controller;
        public LoginView()
        {
            InitializeComponent();
            controller = new FishingAgencyController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"test");
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            controller.Login(username, password);
        }

        private void lblForgottenPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please try to remeber it!", "You forgor?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}