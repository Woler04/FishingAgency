using FishingAgency.Model;
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

        public string GetUsername()
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
                    User userTolog = fadb.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
                    if (userTolog == null)
                    {
                        return false;
                    }
                    MessageBox.Show($"{username} with {password}");
                    logedUser = userTolog;
                    return true;
                }
                //login fail
                catch
                {
                    return false;
                }
            }
        }

        public void Register(string fullName, string username, string password, string shipName)
        {
            //add more validations
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                User user = new User()
                {
                    Name = fullName,
                    Username = username,
                    Password = password,
                    ShipId = fadb.FishingShips.Where(s => s.Name == shipName).FirstOrDefault().Id,
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
