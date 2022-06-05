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
        public static ForgottenPasswordView instance = null;
        public ForgottenPasswordView()
        {
            if (instance == null)
            {
                InitializeComponent();
                regController = new RegistrationController();
                instance = this;
                return;
            }

            this.FormClosed += new FormClosedEventHandler(FormClosed);
            void FormClosed(object sender, FormClosedEventArgs e)
            {
                instance = null;
            }
        }

        private void btnSetPassword_Click(object sender, EventArgs e)
        {
            if (Utility.Validate(txtNewPassword.Text) ||
                Utility.Validate(txtUsername.Text))
            {
                return;
            }

            regController.NewPassord(txtUsername.Text, txtNewPassword.Text, this);
            instance = null;
            this.Close();
        }
    }
}
