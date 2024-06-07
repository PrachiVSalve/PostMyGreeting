using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class StoreVC:ViewComponent
    {
        IReview rvrepo;
        public StoreVC(IReview rvrepo)
        {
            this.rvrepo=rvrepo;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
            var v = this.rvrepo.GetByStoreId(userid);
            TempData["count"]=v.Count();
            return View(v);
        }
    }
}
