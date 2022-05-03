using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishingAgency.Model;

namespace FishingAgency.Controller
{
    internal class FishingAgencyController
    {
        public List<FishingShip> GetFishingShips()
        {
            using (FishingAgencyEntities2 fadb = new FishingAgencyEntities2())
            {
                return fadb.FishingShips.ToList();
            }
        }
        public List<User> GetFishermans()
        {
            using (FishingAgencyEntities2 fadb = new FishingAgencyEntities2())
            {
                return fadb.Users.ToList();
            }
        }
    }
}
