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

        public bool Login(string username, string password)
        {
            //add more validations
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                //success
                if (true)
                {
                    MessageBox.Show($"{username} with {password}");
                    return true;
                }
                //login fail
                else
                {
                    MessageBox.Show($"There is not such user");
                    return false;
                }
            }
        }

        public void Register(string fullName, string username, string password, string shipName)
        {
            //add more validations
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                User user = new User()
                {
                    Name = fullName,
                    Username = username,
                    Password = password,
                    ShipId = fadb.FishingShips.Where(s => s.Name == shipName).FirstOrDefault().Id
                };
            }
        }

        public void SwitchingForms(Form from, Form to)
        {
            to.Location = from.Location;
            to.StartPosition = FormStartPosition.Manual;
            to.Show();
            from.Hide();
        }
    }
}
