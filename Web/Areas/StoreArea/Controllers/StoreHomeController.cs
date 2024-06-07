using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Repo.ViewModel.Change_Password;
using Repo.ViewModel.Profile;
using Web.CustFilter;

namespace Web.Areas.StoreArea.Controllers
{
    [Area("StoreArea")]
    [StoreAuth]
    public class StoreHomeController : Controller
    {
        IStore strrepo;
        ICity ctrepo;
        ICountry crepo;
        IState srepo;
        public StoreHomeController(IStore strrepo, ICity ctrepo, ICountry crepo, IState srepo)
        {
            this.strrepo = strrepo;
            this.ctrepo = ctrepo;
            this.crepo = crepo;
            this.srepo = srepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EditProfile()
        {
           
            //var r=Convert.ToInt64(HttpContext.Session.GetString("AdminID" ));
            Int64 strid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
            var rec = this.strrepo.GetById(strid);
            ViewBag.Countrys = new SelectList(this.crepo.GetAll(), "CountryId", "CountryName", rec.CountryId);
            ViewBag.States = new SelectList(this.srepo.GetAll(), "StateId", "StateName", rec.StateId);
            ViewBag.Citys = new SelectList(this.ctrepo.GetAll(), "CityId", "CityName", rec.CityId);
            return View(rec);
        }

        [HttpPost]
        public IActionResult EditProfile(StoreProVM rec)
        {
            ViewBag.Countrys = new SelectList(this.crepo.GetAll(), "CountryId", "CountryName", rec.CountryId);
            ViewBag.States = new SelectList(this.srepo.GetAll(), "StateId", "StateName", rec.StateId);
            ViewBag.Citys = new SelectList(this.ctrepo.GetAll(), "CityId", "CityName", rec.CityId);
            if (ModelState.IsValid)
            {
                Int64 strid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
                var res = this.strrepo.EditProfile(rec, strid);

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
                Int64 aid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
                var res = this.strrepo.ChangePassword(rec, aid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }
        public IActionResult GetStateJson(Int64 id)
        {
            var rec = this.srepo.GetStateByCountryId(id);
            return Json(rec.ToList());
        }
        public IActionResult GetCityJson(Int64 id)
        {
            var rec = this.ctrepo.GetCityByStateId(id);
            return Json(rec.ToList());
        }

    }
}
