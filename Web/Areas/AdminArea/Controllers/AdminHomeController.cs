using Microsoft.AspNetCore.Mvc;
using Repo;
using Repo.ViewModel.Change_Password;
using Repo.ViewModel.Profile;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [ProjectAuth]
    public class AdminHomeController : Controller
    {
        IAdmin repo;
        public AdminHomeController(IAdmin repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EditProfile()
        {
             //var r=Convert.ToInt64(HttpContext.Session.GetString("AdminID" ));
            Int64 aid = Convert.ToInt64(HttpContext.Session.GetString("AdminID"));
            var rec = this.repo.GetById(aid);
            return View(rec);
        }

        [HttpPost]
        public IActionResult EditProfile(ProfileVM rec)
        {
            if (ModelState.IsValid)
            {
                Int64 aid = Convert.ToInt64(HttpContext.Session.GetString("AdminID"));
                var res = this.repo.EditProfile(rec, aid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordVM rec)
        {
            if (ModelState.IsValid)
            {
                Int64 aid = Convert.ToInt64(HttpContext.Session.GetString("AdminID"));
                var res = this.repo.ChangePassword(rec, aid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }

    }
}
