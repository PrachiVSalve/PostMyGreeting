using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Repo;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [ProjectAuth]
    public class CategoryController : Controller
    {

        ICategory ctgrepo;
        public CategoryController(ICategory ctgrepo)
        {
            this.ctgrepo = ctgrepo;
        }
        public IActionResult Index()
        {

            return View(this.ctgrepo.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category rec)
        {
            if (ModelState.IsValid)
            {
                this.ctgrepo.Add(rec);
                return RedirectToAction("Index");

            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.ctgrepo.GetById(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(Category rec)
        {
         if(ModelState.IsValid)
            {
                this.ctgrepo.Edit(rec);
                return RedirectToAction("Index");
            }
         return View(rec);
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.ctgrepo.Delete(id);  
            return RedirectToAction("Index");
        }
    }
}
