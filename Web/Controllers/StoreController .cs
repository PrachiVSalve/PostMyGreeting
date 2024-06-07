using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Repo.ViewModel.Login;
using Repo.ViewModel.Profile;
using Web.CustFilter;

namespace Web.Controllers
{
     
    public class StoreController : Controller
    {
        IStore strrepo;
        ICountry crepo;
        IState srepo;
        ICity ctrepo;
        public StoreController(IStore strrepo,ICity ctrepo,IState srepo,ICountry crepo)
        {
             this.strrepo=strrepo;
            this.crepo=crepo;
            this.srepo=srepo;
            this.ctrepo=ctrepo;
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            ViewBag.Countrys = new SelectList(this.crepo.GetAll(), "CountryId", "CountryName");
            ViewBag.State = new SelectList(this.srepo.GetAll(), "StateId", "StateName");
            ViewBag.City = new SelectList(this.ctrepo.GetAll(), "CityId", "CityName");


            return View();
        }
        [HttpPost]
        public IActionResult SignUp(StoreProVM rec)
        {
            ViewBag.Countrys = new SelectList(this.crepo.GetAll(), "CountryId", "CountryName");
            ViewBag.State = new SelectList(this.srepo.GetAll(), "StateId", "StateName");
            ViewBag.City = new SelectList(this.ctrepo.GetAll(), "CityId", "CityName");
            if (ModelState.IsValid)
            {
                this.strrepo.SignUp(rec);
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
                var res = this.strrepo.Login(rec);
                if (res.IsSuccess)
                {
                    //divert the user to area
                    HttpContext.Session.SetString("StoreID", res.LoggedInId.ToString());
                    HttpContext.Session.SetString("StoreName", res.LoggedInName);
                    return RedirectToAction("Index", "StoreHome", new { area = "StoreArea" });
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
