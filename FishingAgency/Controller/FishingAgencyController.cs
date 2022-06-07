using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FishingAgency.Model;
using FishingAgency.View;

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

        public List<User> GetUsers()
        {
            using (FishingAgencyEntities2 fadb = new FishingAgencyEntities2())
            {
                return fadb.Users.ToList();
            }
        }

        public FishingShip GetShip(int id)
        {
            using (FishingAgencyEntities2 fadb = new FishingAgencyEntities2())
            {
                return fadb.Users.ToList().ElementAt(id).FishingShip;
            }
        }

        public List<FishingShip> GetShipLicense()
        {
            using (FishingAgencyEntities2 enteties = new FishingAgencyEntities2())
            {
                return enteties.FishingShips.Where(a => a.LicenseExpiration.Month == DateTime.Now.Month + 1).ToList();
            }
        }
    }
}
