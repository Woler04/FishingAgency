using FishingAgency.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingAgency.Controller
{
    public class UpdateShipController
    {
        public void UpdateShip(FishingShip ship, string oldName)
        {
            using (FishingAgencyEntities2 fadb = new FishingAgencyEntities2())
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
                    //To do
                }

                fadb.SaveChanges();
            }
        }
    }
}
