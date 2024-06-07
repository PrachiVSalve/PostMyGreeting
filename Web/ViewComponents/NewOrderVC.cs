using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
     
    public class NewOrderVC:ViewComponent
    {
        IOrder orepo;
        public  NewOrderVC(IOrder orepo)
        {
            this.orepo = orepo;
        }
        public IViewComponentResult Invoke(Int64 storeid)
        {
            var v=this.orepo.GetAllByStoreID(storeid);
            return View(v.ToList());
        }
    }
}
