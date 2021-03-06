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
                List<FishingShip> ships = fadb.FishingShips.ToList();
                ships.Remove(fadb.FishingShips.Where(s => s.Name == "admin").FirstOrDefault());
                return ships;
            }
        }
        public List<FishingShip> GetFishingShipsWithCatches()
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                List<FishingShip> ships = fadb.FishingShips.ToList();
                ships.Remove(fadb.FishingShips.Where(s => s.Name == "admin").FirstOrDefault());
                ships.Where(s => s.Catches.Count > 0).ToList();
                return ships;
            }
        }

        public List<FishingShip> GetFishingShipsWithLicense()
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                List<FishingShip> ships = fadb.FishingShips.ToList();
                ships.Remove(fadb.FishingShips.Where(s => s.Name == "admin").FirstOrDefault());
                ships.Where(s => s.LicenseExpiration >= DateTime.Today && s.Catches.Count > 0).ToList();
                return ships;
            }
        }

        public List<User> GetUsers()
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                List<User> users = fadb.Users.ToList();
                users.Remove(fadb.Users.Where(u => u.Username == "admin").FirstOrDefault());
                return users;
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
                List<User> users = fadb.Users.ToList();
                users.Remove(fadb.Users.Where(u => u.Username == "admin").FirstOrDefault());
                return users.ElementAt(id-1).FishingShip.Name;
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

        public IOrderedEnumerable<KeyValuePair<string, double>> GetHobbyLeaderBoard()
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

        public string CatchMinAvrMaxLenght(FishingShip currship)
        {
            StringBuilder sb = new StringBuilder();
            double min = 0;
            double avr = 0;
            double max = 0;

            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                FishingShip ship = fadb.FishingShips.ToList().Where(s => s.Id == currship.Id).FirstOrDefault();
                min = ship.Catches.Min(c => c.Lenght);
                avr = 0;
                foreach (var ca4 in ship.Catches)
                {
                    avr += ca4.Lenght;
                }

                avr /= ship.Catches.Count;
                max = ship.Catches.Max(c => c.Lenght);
            }

            sb.Append(Math.Round(min, 2) + "/");
            sb.Append(Math.Round(avr, 2));
            sb.Append("/" + Math.Round(max, 2));
            return sb.ToString();
        }

        public string CatchMinAvrMaxAmaunt(FishingShip currship)
        {
            StringBuilder sb = new StringBuilder();
            double min = 0;
            double avr = 0;
            double max = 0;

            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                FishingShip ship = fadb.FishingShips.ToList().Where(s => s.Id == currship.Id).FirstOrDefault();
                min = ship.Catches.Min(c => c.Amount);
                avr = 0;
                foreach (var ca4 in ship.Catches)
                {
                    avr += ca4.Amount;
                }

                avr /= ship.Catches.Count;
                max = ship.Catches.Max(c => c.Amount);
            }

            sb.Append(Math.Round(min, 2) + "/");
            sb.Append(Math.Round(avr, 2));
            sb.Append("/" + Math.Round(max, 2));
            return sb.ToString();
        }

        public int CatchesThisYear(FishingShip currship)
        {
            int res = 0;
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                FishingShip ship = fadb.FishingShips.ToList().Where(s => s.Id == currship.Id).FirstOrDefault();
                {
                    ship.Catches.Where(c => c.StartDate.Year == DateTime.Today.Year).ToList().ForEach(c => res++);
                }
            }

            return res;
        }

        public double AmountThisYear(FishingShip currship)
        {
            double res = 0;
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                FishingShip ship = fadb.FishingShips.ToList().Where(s => s.Id == currship.Id).FirstOrDefault();
                {
                    ship.Catches.Where(c => c.StartDate.Year == DateTime.Today.Year).ToList().ForEach(c => res += c.Amount);
                }
            }

            return Math.Round(res, 2);
        }

        public double EnvPolution(FishingShip currship)
        {
            double envPolution = 0;
            double yearAmount = 0;
            double yearLenght = 0;


            //CARBON OTPECHATYK = (FUEL * ALL IZLETI.CHASOVE) / ALL IZLETI.RIBOLOV

            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                FishingShip ship = fadb.FishingShips.ToList().Where(s => s.Id == currship.Id).FirstOrDefault();
                ship.Catches.Where(c => c.StartDate >= DateTime.Today.AddYears(-1)).ToList().ForEach(c =>
                {
                    yearAmount += c.Amount;
                    yearLenght += c.Lenght;
                });

            }

            envPolution = (currship.FuelUsage * yearAmount) / yearLenght;
            return envPolution;
        }
    }
}
