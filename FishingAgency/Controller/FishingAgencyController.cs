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

        public List<Catch> GetCatches()
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                return fadb.Catches.ToList();
            }
        }

        public string GetShipsNames(int id)
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                return fadb.Users.ToList().ElementAt(id).FishingShip.Name;
            }
        }
        public string GetShipNameByCatch(Catch catc)
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                return fadb.FishingShips.Where(s => s.Id == catc.ShipId).FirstOrDefault().Name;
            }
        }

        public int GetCatchCountByShip(FishingShip ship)
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                return fadb.FishingShips.Where(s => s.Id == ship.Id).FirstOrDefault().Catches.Count;
            }
        }

        public IOrderedEnumerable<KeyValuePair<string,double>> GetHobbyLeaderBoard()
        {
            SortedDictionary<string, double> shipsAndCatch = new SortedDictionary<string, double>();
            List<User> forHobby = new List<User>();

            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                forHobby = fadb.Users.Where(u => u.FishingShip.isForHobby == true && u.FishingShip.Catches.Count > 0).ToList();
                foreach (var user in forHobby)
                {
                    double amountSum = 0;
                    user.FishingShip.Catches.ToList().ForEach(c => amountSum += c.Amount);
                    //if (shipsAndCatch.ContainsKey(user.Name))
                    //{
                    //    shipsAndCatch[user.Name] += amountSum;
                    //}
                    //else 
                    //{
                        shipsAndCatch.Add(user.Name, amountSum);
                    //}
                    
                }
            }

            var sortedDict = from entry in shipsAndCatch orderby entry.Value descending select entry;
            return sortedDict;
        }
    }
}
