using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class GiftComplaintVC:ViewComponent
    {
        IOrder orepo;
        public GiftComplaintVC(IOrder orepo)
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
