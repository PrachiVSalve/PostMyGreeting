using Microsoft.AspNetCore.Mvc;
using Repo;
using Repo.ViewModel.Login;
using Web.CustFilter;

namespace Web.Controllers
{
     
    public class AdminController : Controller
    {
        IAdmin Arepo;
        public AdminController(IAdmin Arepo)
        {
            this.Arepo = Arepo;
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(LoginVM rec)
        {
            if (ModelState.IsValid)
            {
                var res = this.Arepo.Login(rec);
                if (res.IsSuccess)
                {
                    //divert the user to area
                    HttpContext.Session.SetString("AdminID", res.LoggedInId.ToString());
                    HttpContext.Session.SetString("AdminName", res.LoggedInName);
                    return RedirectToAction("Index", "AdminHome", new { area = "AdminArea" });
                }
                else
                {
                    ModelState.AddModelError("", res.ErrorMessage);
                    return View(rec);
                }
            }
            return View(rec);
           
        }
        [HttpGet]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("SignIn");
        }
    }
}
