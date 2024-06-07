using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class GiftVC:ViewComponent
    {
        IOrder orepo;
        public GiftVC(IOrder orepo)
        {
            this.orepo = orepo;
        }
        public IViewComponentResult Invoke(Int64 OrderId)
        {
            var res = this.orepo.GetAllByOrderId(OrderId);
             
            return View(res);
        }
    }
}
