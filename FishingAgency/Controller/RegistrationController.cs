using FishingAgency.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FishingAgency.Model;

namespace FishingAgency.Controller
{
    public class RegistrationController
    { 
        public bool Login(string username, string password)
        {
            //add more validations
            using (FishingAgencyEntities2 fadb = new FishingAgencyEntities2())
            {
                //success
                try
                {
                    User userTolog = fadb.Users.Where(u => u.Username == username).FirstOrDefault();
                    if (userTolog != null)
                    {
                        if (userTolog.Username == username && userTolog.Password != password)
                        {
                            MessageBox.Show($"Wrong password");
                            return false;
                        }

                        MessageBox.Show($"Welcome {userTolog.Name}");
                        Utility.LoggedUser = userTolog;
                        return true;
                    }

                    return false;
                }
                //login fail
                catch
                {
                    MessageBox.Show($"Somehow you've messed u :/");
                    return false;
                }
            }
        }

        public bool Register(string fullName, string username, string password, string shipName)
        {
            //add more validations
            using (FishingAgencyEntities2 fadb = new FishingAgencyEntities2())
            {
                FishingShip shipToCheck = fadb.FishingShips.Where(s => s.Name == shipName).FirstOrDefault();
                if (shipToCheck == null)
                {
                    var res = MessageBox.Show($"There is not such ship. Want to add one?", "No ship?", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        AddShipView addShip = new AddShipView();
                        addShip.Show();
                    }
                    return false;
                }

                User user = new User()
                {
                    Name = fullName,
                    Username = username,
                    Password = password,
                    ShipId = fadb.FishingShips.Where(s => s.Name == shipName).FirstOrDefault().Id
                };

                if (fadb.Users.ToList().LastOrDefault() == null)
                {
                    user.Id = 0;
                }
                else
                {
                    user.Id = fadb.Users.ToList().LastOrDefault().Id + 1;
                }
                fadb.Users.Add(user);
                fadb.SaveChanges();
                return true;
            }
        }

        public void NewPassord(string username, string newPassword, Form formToClose)
        {
            using (FishingAgencyEntities2 fadb = new FishingAgencyEntities2())
            {
                User userToUpdate = fadb.Users.Where(u => u.Username == username).FirstOrDefault();
                if (userToUpdate != null)
                {
                    userToUpdate.Password = newPassword;
                    fadb.SaveChanges();
                    formToClose.Close();
                }
                else
                {
                    MessageBox.Show("No username");
                }
            }
        }
    }
}
