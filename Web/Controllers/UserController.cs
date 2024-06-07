using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Repo.ViewModel.Login;
using Repo.ViewModel.Profile;
using Web.CustFilter;

namespace Web.Controllers
{
     
    public class UserController : Controller
    {
        IUser urepo;
        public UserController(IUser urepo )
        {
              this.urepo = urepo;
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            


            return View();
        }
        [HttpPost]
        public IActionResult SignUp(UserProfileVM rec)
        {
             
            if (ModelState.IsValid)
            {
                this.urepo.SignUp(rec);
                return RedirectToAction("SignIn");
            }
            return View(rec);
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
                var res = this.urepo.Login(rec);
                if (res.IsSuccess)
                {
                    //divert the user to area
                    HttpContext.Session.SetString("UserID", res.LoggedInId.ToString());
                    HttpContext.Session.SetString("UserName", res.LoggedInName);
                    return RedirectToAction("Index", "Home");
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
