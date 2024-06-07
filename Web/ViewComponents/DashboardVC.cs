using Microsoft.AspNetCore.Mvc;
using Repo;

namespace web.ViewComponents
{
    public class DashboardVC:ViewComponent
    {
        IOrder orepo;
        public DashboardVC(IOrder orderRepo)
        {
            this.orepo = orderRepo;
        }

        public IViewComponentResult Invoke(Int64 userid)
        {
            var res = this.orepo.GetOrderDetByUserID(userid);
            return View(res);        
        }
    }
}
