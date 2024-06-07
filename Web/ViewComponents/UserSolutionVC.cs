using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class UserSolutionVC:ViewComponent
    {
        IOrder orepo;
        public UserSolutionVC(IOrder orepo)
        {
            this.orepo = orepo;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
            var v = this.orepo.GetAllSolvedComplaints(userid);
            return View(v.ToList());
        }
    }
}
