using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FishingAgency.Model;

namespace FishingAgency.Controller
{
    internal class FishingAgencyController
    {
        static private User logedUser;

        public string GetUsername()
        {
            return logedUser.Name;
        }

        public List<FishingShip> GetFishingShips()
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                return fadb.FishingShips.ToList();
            }
        }

        public List<User> GetFishermans()
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                return fadb.Users.ToList();
            }
        }

        public bool Login(string username, string password)
        {
            //add more validations
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                //success
                try { 
                    User userTolog = fadb.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
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
                    ShipId = fadb.FishingShips.Where(s => s.Name == shipName).FirstOrDefault().Id
                };
            }
        }

        public void AddShip(FishingShip shipToAdd)
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                shipToAdd.Id = fadb.FishingShips.ToList().Last().Id + 1;
                fadb.FishingShips.Add(shipToAdd);
                fadb.SaveChanges();
            }
        }

        public void SwitchingForms(Form from, Form to)
        {
            to.Location = from.Location;
            to.StartPosition = FormStartPosition.Manual;
            to.Show();
            from.Hide();
        }
    }
}
