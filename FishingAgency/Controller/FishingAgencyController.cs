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

        public FishingShip GetShip(int id)
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                return fadb.Users.ToList().ElementAt(id).FishingShip;
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

        public void Update(FishingShip ship, string oldName)
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                FishingShip shipToUpdate = fadb.FishingShips.Where(s => s.Name == oldName).FirstOrDefault();

                if (shipToUpdate != null)
                {
                    shipToUpdate.Name = ship.Name;
                    shipToUpdate.isForHobby = ship.isForHobby;
                    shipToUpdate.FuelUsage = ship.FuelUsage;
                    shipToUpdate.LicenseExpiration = ship.LicenseExpiration;
                }
                else
                {
                    AddShip(ship);
                }

                fadb.SaveChanges();
            }
        }

        public void DeleteShip(string shipName)
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                FishingShip shipToDelete = fadb.FishingShips.Where(s => s.Name == shipName).FirstOrDefault();
                if (shipToDelete.Users.ToList() == null)
                {
                    fadb.FishingShips.Remove(shipToDelete);
                }
                else 
                {
                    MessageBox.Show("Unable to delete this ship because it's connected with people", "Error 16", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
