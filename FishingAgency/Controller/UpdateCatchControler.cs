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
    public class UpdateCatchControler
    {
        /*public Func<Catch, Catch, bool> CompareCatches = (c, oldCatch) =>
        {
            if (c.StartDate == oldCatch.StartDate &&
            c.Lenght == oldCatch.Lenght &&
            c.FishingShip == oldCatch.FishingShip &&
            c.Amount == oldCatch.Amount)
            {
                return true;
            }
            return false;
        };*/

        public void UpdateCatch(Catch newCatch, FishingShip fishingShip)
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                Catch catchToUpdate = fadb.Catches.ToList().Where(c => c.Id == newCatch.Id).LastOrDefault();

                if (newCatch != null)
                {
                    catchToUpdate.Amount = newCatch.Amount;
                    catchToUpdate.Lenght = newCatch.Lenght;
                    catchToUpdate.StartDate = newCatch.StartDate;
                    catchToUpdate.ShipId = fishingShip.Id;
                    fadb.SaveChanges();
                }
                else
                {
                    Utility.Error16();
                }
            }
        }
    }
}
