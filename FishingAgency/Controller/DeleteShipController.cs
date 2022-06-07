using FishingAgency.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingAgency.Controller
{
    public class DeleteShipController
    {
        public void DeleteShip(string shipName)
        {
            using (FishingAgencyEntities2 fadb = new FishingAgencyEntities2())
            {
                FishingShip shipToDelete = fadb.FishingShips.Where(s => s.Name == shipName).FirstOrDefault();
                if (shipToDelete.Users.ToList() == null)
                {
                    fadb.FishingShips.Remove(shipToDelete);
                }
                else
                {
                    MessageBox.Show("Unable to delete this ship because it's connected with people", "Error 16", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fadb.SaveChanges();
            }
        }
    }
}
