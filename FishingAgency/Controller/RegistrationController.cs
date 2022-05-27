using FishingAgency.Model;
using FishingAgency.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingAgency.Controller
{
    public class RegistrationController
    {
        static private User logedUser;

        public string GetLogedName()
        {
            return logedUser.Name;
        }

        public bool Login(string username, string password)
        {
            //add more validations
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
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
                        logedUser = userTolog;
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
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
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

        public void UpdateUser(User newData, string oldPassword)
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                User userToUpdate = fadb.Users.Where(u => u.Password == oldPassword).FirstOrDefault();

                if (userToUpdate != null)
                {
                    userToUpdate.Name = newData.Name;
                    userToUpdate.Password = newData.Password;
                    userToUpdate.ShipId = logedUser.ShipId;
                }

                fadb.SaveChanges();
            }
        }

        public void NewPassord(string username, string newPassword, Form formToClose)
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
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

        public bool Validate(string textToValidate)
        {
            if (textToValidate.Length < 0 || String.IsNullOrWhiteSpace(textToValidate) || String.IsNullOrEmpty(textToValidate))
            {
                MessageBox.Show("Please don't leave empty fields");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
