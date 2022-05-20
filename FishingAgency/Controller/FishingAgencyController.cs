﻿using System;
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
                string usernameToCheck = fadb.Users.Where(u => u.Username.ToString() == username).FirstOrDefault().Username.ToString();
                string passwordToCheck = fadb.Users.Where(u => u.Password.ToString() == password).FirstOrDefault().Password.ToString();
                if (usernameToCheck == username && passwordToCheck == password)
                {
                    MessageBox.Show($"{usernameToCheck} with password {passwordToCheck}");
                }
                else
                {
                    MessageBox.Show($"Something went wrong");
                }
            }
        }
    }
}
