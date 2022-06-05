using FishingAgency.Model;
using FishingAgency.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingAgency.Controller
{
    public class AddCatchController
    {
        public void AddCatch(Catch catchToAdd, string shipName)
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                FishingShip shipToCheck = fadb.FishingShips.Where(s => s.Name == shipName).FirstOrDefault();
                if (shipToCheck == null)
                {
                    var res = MessageBox.Show($"There is not such ship. Want to add one?", "No ship?", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        AddShipView addShip = new AddShipView();
                        addShip.Show();
                    }
                    return;
                }

                catchToAdd.Id = fadb.Catches.ToList().LastOrDefault().Id + 1;
                catchToAdd.ShipId = shipToCheck.Id;
                fadb.Catches.Add(catchToAdd);
                fadb.SaveChanges();
            }
        }
    }
}
