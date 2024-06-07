using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [ProjectAuth]
    public class StateController : Controller
    {
        IState srepo;
        ICountry crepo;
        public StateController(IState srepo ,ICountry crepo)
        {
            this.srepo = srepo;
            this.crepo = crepo;
        }
        public IActionResult Index()
        {
            return View(this.srepo.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Countries = new SelectList(this.crepo.GetAll(), "CountryId", "CountryName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(State rec)
        {
            ViewBag.Countries = new SelectList(this.crepo.GetAll(), "CountryId", "CountryName");
            if (ModelState.IsValid)
            {
                this.srepo.Add(rec);
                return RedirectToAction("Index");
            }
           return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
           
            var rec = this.srepo.GetById(id);
            ViewBag.Countries = new SelectList(this.crepo.GetAll(), "CountryId", "CountryName",rec.CountryId);
            return View(rec);

        }
        [HttpPost]
        public IActionResult Edit(State rec)
        {
            ViewBag.Countries = new SelectList(this.crepo.GetAll(), "CountryId", "CountryName",rec.CountryId);
            if (ModelState.IsValid)
            {
                this.srepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.srepo.Delete(id);
            return RedirectToAction("Index");
        }
        
    }
}
