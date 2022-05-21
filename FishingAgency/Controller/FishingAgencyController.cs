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

        public void Login(string username, string password)
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                var user = fadb.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
                if (user != null)
                {
                    MessageBox.Show($"Welcome {username}");
                }
                else
                {
                    MessageBox.Show($"Wrong username or password");
                }
            }
        }
    }
}
