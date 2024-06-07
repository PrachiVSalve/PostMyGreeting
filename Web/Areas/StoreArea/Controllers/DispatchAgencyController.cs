using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;
using Web.CustFilter;

namespace Web.Areas.StoreArea.Controllers
{
    [Area("StoreArea")]
    [StoreAuth]
    public class DispatchAgencyController : Controller
    {
        IdispatchAgency darepo;
        public DispatchAgencyController(IdispatchAgency darepo)
        {
            this.darepo= darepo;
        }
        public IActionResult Index()
        {
            return View(this.darepo.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
           return View();   
        }
        [HttpPost]
        public IActionResult Create(DispatchAgency rec)
        {if(ModelState.IsValid)
            {
                this.darepo.Add(rec);   
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        { var rec=this.darepo.GetById(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(DispatchAgency rec)
        {
            if (ModelState.IsValid)
            {
               this.darepo.Edit(rec); 
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        public IActionResult Delete(Int64 id)
        {
            this.darepo.Delete(id);
            return RedirectToAction ("Index");
        }
         
    }
}
