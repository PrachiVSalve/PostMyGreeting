using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class StoreReviewVC:ViewComponent
    {
        IReview rvrepo;
        public StoreReviewVC(IReview rvrepo)
        {
          this.rvrepo = rvrepo;
        }
         
        public IViewComponentResult Invoke(Int64 userid)
        {
            TempData["userid"]=userid; 
            return View();
        }
    }
}
