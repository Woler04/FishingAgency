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
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                return fadb.FishingShips.ToList();
            }
        }

        public List<User> GetUsers()
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
    }
}
