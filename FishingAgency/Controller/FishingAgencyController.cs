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

        internal void Update(string oldName, string newName, DateTime newLicense, bool newIsHobby, double newFuelConsuption)
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
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

        public void DeleteShip(string shipName)
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                fadb.FishingShips.Remove(fadb.FishingShips.Where(s => s.Name == shipName).FirstOrDefault());
                fadb.SaveChanges();
            }
        }

        public bool ValidateUsername(string usernameToAdd)
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                foreach (User user in GetFishermans())
                {
                    if (user.Username == usernameToAdd)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public void Refresh()
        {
            GetFishingShips();
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
