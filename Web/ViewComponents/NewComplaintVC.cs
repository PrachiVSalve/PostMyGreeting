using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class NewComplaintVC:ViewComponent
    {
        IOrder orepo;
        public NewComplaintVC(IOrder orepo)
        {
            this.orepo = orepo;
        }   
        public IViewComponentResult Invoke(Int64  storeid)
        {
            var v = this.orepo.GetAllNewComplaints(storeid);
            return View(v.ToList());
        }
    }
}
