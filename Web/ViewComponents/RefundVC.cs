using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class RefundVC: ViewComponent
    {
        IOrder orepo;
        public RefundVC(IOrder orepo)
        {
            this.orepo = orepo;
        }
        public IViewComponentResult Invoke(Int64 storeid)
        {
              var v = this.orepo.GetAllByRefund(storeid);
                return View(v.ToList());
            
        }
    }
}
