using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class GiftsVC: ViewComponent
    {
        ICart crt;
        public GiftsVC(ICart crt)
        {
         this.crt = crt;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
            var res = this.crt.GetAllByUserId(userid);
            List<decimal> Amount = res.Select(p => p.Price * p.Qty).ToList();
            decimal amt = Amount.Sum();
            TempData["totalGift"] = amt;
            return View(res);
        }
    }
}
