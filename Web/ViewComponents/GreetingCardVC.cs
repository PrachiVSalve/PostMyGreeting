using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class GreetingCardVC:ViewComponent
    {
        IOrder orepo;
        public GreetingCardVC(IOrder orepo)
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
