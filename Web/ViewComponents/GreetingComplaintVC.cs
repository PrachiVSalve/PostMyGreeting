using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class GreetingComplaintVC:ViewComponent
    {
        IOrder orepo;
        public GreetingComplaintVC(IOrder orepo)
        {
            this.orepo = orepo;
        }
        public IViewComponentResult Invoke(Int64 OrderId)
        {
            var res = this.orepo.GetGreetingByOrderId(OrderId);

            return View(res);
        }
    }
}
