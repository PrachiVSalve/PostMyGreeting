using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [ProjectAuth]
    public class CityController : Controller
    {
        ICity ctRepo;
        IState srepo;
        ICountry crepo;
        public CityController(ICity ctRepo, IState srepo, ICountry crepo)
        {
            this.ctRepo = ctRepo;
            this.srepo = srepo;
            this.crepo = crepo;
        }
        public IActionResult Index()
        {
            return View(this.ctRepo.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.StateId = new SelectList(this.srepo.GetAll(), "StateId", "StateName");
            ViewBag.CountryId = new SelectList(this.crepo.GetAll(), "CountryId", "CountryName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(City rec)
        {
            ViewBag.StateId = new SelectList(this.srepo.GetAll(), "StateId", "StateName");
            ViewBag.CountryId = new SelectList(this.crepo.GetAll(), "CountryId", "CountryName");
            if (ModelState.IsValid)
            {
                this.ctRepo.Add(rec);
                return RedirectToAction("Index");   
            }
         return View(rec);
        }
        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            var rec = this.ctRepo.GetById(id);
            ViewBag.Statess = new SelectList(this.srepo.GetAll(), "StateId", "StateName", rec.StateId);
            ViewBag.Countryss = new SelectList(this.crepo.GetAll(), "CountryId", "CountryName", rec.State.CountryId);

            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(City rec)
        {
            ViewBag.Statess = new SelectList(this.srepo.GetAll(), "StateId", "StateName", rec.StateId);

            if (ModelState.IsValid)
            {
                this.ctRepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            this.ctRepo.Delete(id);
            return RedirectToAction("Index");
     
        }
        public IActionResult GetStateJson(Int64 id)
        {
            var rec = this.srepo.GetStateByCountryId(id);
            return Json(rec.ToList());
        }
        //public IActionResult GetCityJson(Int64 id)
        //{
        //    var rec = this.ctRepo.GetCityByStateId(id);
        //    return Json(rec.ToList());
        //}
    }
}
