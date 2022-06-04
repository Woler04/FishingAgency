using FishingAgency.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingAgency.Controller
{
    public static class Utility
    {
        static private User logedUser;

        public static User LoggedUser
        {
            get => logedUser;
            set => logedUser = value;
        }

        public static bool Validate(string textToValidate)
        {
            if (textToValidate.Length < 0 || String.IsNullOrWhiteSpace(textToValidate) || String.IsNullOrEmpty(textToValidate))
            {
                MessageBox.Show("Please don't leave empty fields");
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateUsername(string usernameToAdd)
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                foreach (User user in fadb.Users.ToList())
                {
                    if (user.Username == usernameToAdd)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public static void SwitchingForms(Form from, Form to)
        {
            to.Location = from.Location;
            to.StartPosition = FormStartPosition.Manual;
            to.Show();
            from.Hide();
        }
    }
}
