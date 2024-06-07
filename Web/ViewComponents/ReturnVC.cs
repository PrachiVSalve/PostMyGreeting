using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class ReturnVC:ViewComponent
    {
        IOrder orepo;
        public ReturnVC(IOrder orepo)
        {
            this.orepo = orepo;
        }
        public IViewComponentResult Invoke(Int64 storeid)
        {
            var v = this.orepo.GetReturn(storeid);
            return View(v.ToList());
        }
    }
}
