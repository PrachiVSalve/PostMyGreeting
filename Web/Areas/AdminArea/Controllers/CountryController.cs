using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Repo;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [ProjectAuth]
    public class CountryController : Controller
    {

        ICountry crepo;
        public CountryController(ICountry crepo)
        {
            this.crepo = crepo;
        }
        public IActionResult Index()
        {

            return View(this.crepo.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Country rec)
        {
            if (ModelState.IsValid)
            {
                this.crepo.Add(rec);
                return RedirectToAction("Index");

            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.crepo.GetById(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Country rec)
        {
         if(ModelState.IsValid)
            {
                this.crepo.Edit(rec);
                return RedirectToAction("Index");
            }
         return View(rec);
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.crepo.Delete(id);  
            return RedirectToAction("Index");
        }
    }
}
