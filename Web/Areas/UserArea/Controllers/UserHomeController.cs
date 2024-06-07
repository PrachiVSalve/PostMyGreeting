using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Repo.ViewModel.Change_Password;
using Repo.ViewModel.Profile;
using Web.CustFilter;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
   
    public class UserHomeController : Controller
    {
        IUser urepo;
        //ICountry crepo;
        //IState srepo;
        //ICity ctrepo;
         
        public UserHomeController(IUser urepo/*,ICountry crepo,IState srepo,ICity ctrepo*/)
        {
             this.urepo= urepo;
            //this.crepo= crepo;
            //this.srepo= srepo;
            //this.ctrepo= ctrepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EditProfile()
        {
           
            
            Int64 uid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var rec = this.urepo.GetById(uid);
            //ViewBag.Countrys = new SelectList(this.crepo.GetAll(), "CountryId", "CountryName", rec.CountryId);
            //ViewBag.States = new SelectList(this.srepo.GetAll(), "StateId", "StateName", rec.StateId);
            //ViewBag.Citys = new SelectList(this.ctrepo.GetAll(), "CityId", "CityName", rec.CityId);
            return View(rec);
        }

        [HttpPost]
        public IActionResult EditProfile(EditUserProfileVM rec)
        {
            //ViewBag.Countrys = new SelectList(this.crepo.GetAll(), "CountryId", "CountryName", rec.CountryId);
            //ViewBag.States = new SelectList(this.srepo.GetAll(), "StateId", "StateName", rec.StateId);
            //ViewBag.Citys = new SelectList(this.ctrepo.GetAll(), "CityId", "CityName", rec.CityId);
            if (ModelState.IsValid)
            {
                Int64 uid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
                var res = this.urepo.EditProfile(rec, uid);

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
                Int64 aid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
                var res = this.urepo.ChangePassword(rec, aid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }
        //public IActionResult GetStateJson(Int64 id)
        //{
        //    var rec = this.srepo.GetStateByCountryId(id);
        //    return Json(rec.ToList());
        //}
        //public IActionResult GetCityJson(Int64 id)
        //{
        //    var rec = this.ctrepo.GetCityByStateId(id);
        //    return Json(rec.ToList());
        //}

    }
}
