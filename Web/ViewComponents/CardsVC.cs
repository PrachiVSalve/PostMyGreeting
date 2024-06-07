using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class CardsVC:ViewComponent
    {
        ICart crt;
        public CardsVC(ICart crt)
        {
            this.crt = crt;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
            var res = this.crt.GetGreetingByUserId(userid);
            List<decimal> Amount = res.Select(p => p.Price * p.Qty).ToList();
            decimal amt = Amount.Sum();
            TempData["totalcard"] = amt;
            return View(res);
        }
    }
}
