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
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                if (fadb.FishingShips.ToList().FirstOrDefault() == null)
                {
                    shipToAdd.Id = 0;
                }
                else
                {
                    shipToAdd.Id = fadb.FishingShips.ToList().LastOrDefault().Id + 1;
                }
                
                fadb.FishingShips.Add(shipToAdd);
                fadb.SaveChanges();
            }
        }
    }
}
