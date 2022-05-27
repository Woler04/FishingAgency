using FishingAgency.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingAgency.View.DialogViews
{
    public partial class ForgottenPasswordView : Form
    {
        RegistrationController regController;
        public ForgottenPasswordView()
        {
            InitializeComponent();
            regController = new RegistrationController();
        }

        private void btnSetPassword_Click(object sender, EventArgs e)
        {
            if (regController.Validate(txtNewPassword.Text) ||
                regController.Validate(txtUsername.Text))
            {
                return;
            }

            regController.NewPassord(txtUsername.Text, txtNewPassword.Text, this);

        }
    }
}
