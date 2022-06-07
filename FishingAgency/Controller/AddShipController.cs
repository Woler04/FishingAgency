using FishingAgency.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingAgency.Controller
{
    public class AddShipController
    {
        public void AddShip(FishingShip shipToAdd)
        {
            using (FishingAgencyEntities2 fadb = new FishingAgencyEntities2())
            {
                shipToAdd.Id = fadb.FishingShips.ToList().Last().Id + 1;
                fadb.FishingShips.Add(shipToAdd);
                fadb.SaveChanges();
            }
        }
    }
}
