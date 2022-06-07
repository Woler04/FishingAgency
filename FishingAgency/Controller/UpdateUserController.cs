using FishingAgency.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingAgency.Controller
{
    public class UpdateUserController
    {
        public bool UpdateUser(User newUser, string oldPassword)
        {
            using (FishingAgencyEntities2 fadb = new FishingAgencyEntities2())
            {
                User userToUpdate = fadb.Users.Where(u => u.Password == oldPassword && u.Name == newUser.Name).FirstOrDefault();

                if (Utility.ValidateUsername(newUser.Username))
                {
                    MessageBox.Show("This username already exist");
                    return false;
                }

                if (userToUpdate != null && userToUpdate.Name == newUser.Name)
                {
                    userToUpdate.Name = newUser.Name;
                    userToUpdate.Username = newUser.Username;
                    userToUpdate.Password = newUser.Password;
                    userToUpdate.ShipId = Utility.LoggedUser.ShipId;
                    fadb.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Not your password");
                    return false;
                }

                return true;
            }
        }
    }
}
