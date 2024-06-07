using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [ProjectAuth]
    public class SubCategoryController : Controller
    {
        ISubCategory sbctrepo;
        ICategory ctgrepo;
        public SubCategoryController(ISubCategory sbctrepo ,ICategory ctgrepo)
        {
           this.sbctrepo = sbctrepo;
            this.ctgrepo = ctgrepo;
        }
        public IActionResult Index()
        {
            return View(this.sbctrepo.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Cat = new SelectList(this.ctgrepo.GetAll(), "CategoryID", "CategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(SubCategory rec)
        {
            ViewBag.Cat = new SelectList(this.ctgrepo.GetAll(), "CategoryID", "CategoryName");
            if (ModelState.IsValid)
            {
                this.sbctrepo.Add(rec);
                return RedirectToAction("Index");
            }
           return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
           
            var rec = this.sbctrepo.GetById(id);
            ViewBag.Cat = new SelectList(this.ctgrepo.GetAll(), "CategoryID", "CategoryName",rec.CategoryID);
            return View(rec);

        }
        [HttpPost]
        public IActionResult Edit(SubCategory rec)
        {
            ViewBag.Cat = new SelectList(this.ctgrepo.GetAll(), "CategoryID", "CategoryName", rec.CategoryID);
            if (ModelState.IsValid)
            {
                this.sbctrepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.sbctrepo.Delete(id);
            return RedirectToAction("Index");
        }
        
    }
}
