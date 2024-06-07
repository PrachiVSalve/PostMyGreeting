using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;
using Repo.ViewModel;

namespace Web.Controllers
{
    public class StoreReviewController : Controller
    {
        IReview rvrepo;
        public StoreReviewController(IReview rvrepo)
        {
            this.rvrepo=rvrepo;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StoreReview(Int64 storeid)
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            if (userid == 0)
            {
                return RedirectToAction("SignIn", "User");

            }
            else
            {
                //var res=this.crepo.Review(userid, storeid);
                return View();
            }
        }
        [HttpPost]
        public IActionResult ReviewOfStore(StoreReviewVM rec)
        {
            if (ModelState.IsValid)
            {
                var v = this.rvrepo.AddStoreReview(rec);
                TempData["Message"] = v.Message;
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        public IActionResult ViewReview()
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            //Int64 storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
            return View(this.rvrepo.GetByAllStoresId(userid));
        }

    }
}
