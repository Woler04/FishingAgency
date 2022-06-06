using FishingAgency.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingAgency.Controller
{
    public static class DeleteCatchController
    {
        public static void DeleteCatch(Catch catchTD)
        {
            using (FishingAgencyEntities fadb = new FishingAgencyEntities())
            {
                Catch catchToDelete = fadb.Catches.Where(c => c.Id == catchTD.Id).FirstOrDefault();
                fadb.Catches.Remove(catchToDelete);
                fadb.SaveChanges();
            }
        }
    }
}
