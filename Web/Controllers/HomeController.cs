using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;

namespace Web.Controllers
{
  

    public class HomeController : Controller
    {
        IState srepo;
        ICity ctrepo;
        ISubCategory sbctgrepo;
        IGiftItem grepo;
        ICategory crepo;
        IGreetingCard gcrepo;
        public  HomeController(ICity ctrepo, IState srepo, ISubCategory sbctgrepo, IGiftItem grepo, ICategory crepo, IGreetingCard gcrepo)
        {
            this.srepo = srepo;
            this.ctrepo = ctrepo;
            this.sbctgrepo = sbctgrepo;
            this.grepo = grepo;
            this.crepo = crepo;
            this.gcrepo = gcrepo;
        }

        public IActionResult Index()
        {
            ViewBag.CategotyID = new SelectList(this.crepo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.SubCategoryId = new SelectList(this.sbctgrepo.GetAll(), "SubCategoryId", "SubCategoryName");
            return View();
        }
        public IActionResult Gift()
        {
            ViewBag.CategotyID = new SelectList(this.crepo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.SubCategoryId = new SelectList(this.sbctgrepo.GetAll(), "SubCategoryId", "SubCategoryName");
            return View();
        }
        public IActionResult Greeting()
        {
            ViewBag.CategotyID = new SelectList(this.crepo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.SubCategoryId = new SelectList(this.sbctgrepo.GetAll(), "SubCategoryId", "SubCategoryName");
            return View();
        }
        public IActionResult searchByProperty(Int64 protype, Int64 subcat)
        {
            
            if (protype == 1)
            {
                var rec = this.gcrepo.SearchByProductType(protype, subcat);
                ViewBag.rec = rec;
                return View("Greeting", rec);
            }
            else if (protype == 2)
            {
                var rec = this.grepo.SearchByProductType(protype, subcat);
                ViewBag.rec = rec;
                return View("Gift", rec);
            }
            return View();
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
        public IActionResult GetSubCategoryJson(Int64 id)
        {
            var rec = this.sbctgrepo.GetSubCategoryByCategoryId(id);
            return Json(rec.ToList());
        }

    }
}
