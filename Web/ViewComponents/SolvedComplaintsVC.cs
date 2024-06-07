using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class SolvedComplaintsVC : ViewComponent
    {
        IOrder orepo;
        public SolvedComplaintsVC(IOrder orepo)
        {
            this.orepo = orepo;
        }
        public IViewComponentResult Invoke(Int64 storeid)
        {
            var v = this.orepo.GetAllSolvedComplaints(storeid);
            return View(v.ToList());
        }
    }
}
