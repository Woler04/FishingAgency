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
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                User userToUpdate = fadb.Users.Where(u => u.Password == oldPassword && u.Username == newUser.Username).FirstOrDefault();

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
