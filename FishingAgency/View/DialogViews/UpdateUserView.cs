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
        UpdateUserController updateUserControllerController;
        public static UpdateUserView instance = null;
        public UpdateUserView()
        {
            if (instance == null)
            {
                InitializeComponent();
                updateUserControllerController = new UpdateUserController();
                instance = this;
                txtUsername.Text = Utility.LoggedUser.Username;
                txtShip.Text = Utility.LoggedShip.Name;
                txtNewPassword.Text = Utility.LoggedUser.Password;
            }

            this.FormClosed += new FormClosedEventHandler(FormClosed);
            void FormClosed(object sender, FormClosedEventArgs e)
            {
                instance = null;
            }
        }

        private void btnUpdateShip_Click(object sender, EventArgs e)
        {
            if (Utility.Validate(txtNewPassword.Text) ||
            Utility.Validate(txtOldPassword.Text) ||
            Utility.Validate(txtShip.Text)||
            Utility.Validate(txtUsername.Text))
            {
                return;
            }

            User newUser = new User()
            {
                Name = Utility.LoggedUser.Name,
                Username = txtUsername.Text,
                Password = txtNewPassword.Text,
            };

            if (Utility.LoggedUser.Password != txtOldPassword.Text)
            {
                MessageBox.Show("Not matching passwords");
                return;
            }

            if (updateUserControllerController.UpdateUser(newUser, txtOldPassword.Text, txtShip.Text))
            {
                instance = null;
                this.Close();
            }
        }
    }
}
