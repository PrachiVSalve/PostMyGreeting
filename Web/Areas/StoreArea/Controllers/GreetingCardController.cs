using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Identity.Client;
using Repo;
using Repo.ViewModel;
using Web.CustFilter;

namespace Web.Areas.StoreArea.Controllers
{
    [Area("StoreArea")]
    [StoreAuth]
    public class GreetingCardController : Controller
    {

        IGreetingCard gcrepo;
        ICategory catgrepo;
        ISubCategory sbctgrepo;
        IWebHostEnvironment wbhenv;
         

        public GreetingCardController( IGreetingCard gcrepo, ICategory catgrepo, ISubCategory sbctgrepo,IWebHostEnvironment wbhenv )
        {
            this.gcrepo= gcrepo;
            this.catgrepo = catgrepo;
            this.sbctgrepo = sbctgrepo;
            this.wbhenv = wbhenv;
            
             
            
        }
        public IActionResult Index()
        {
            ViewBag.Cat = new SelectList(this.catgrepo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.SubCat = new SelectList(this.sbctgrepo.GetAll(), "SubCategoryId", "SubCategoryName");
            var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
            return View(this.gcrepo.GetAllByStoreID(storeid));
             
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Cat = new SelectList(this.catgrepo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.SubCat= new SelectList(this.sbctgrepo.GetAll(), "SubCategoryId", "SubCategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(GreetingCardVM rec)
        {
            ViewBag.Cat = new SelectList(this.catgrepo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.SubCat = new SelectList(this.sbctgrepo.GetAll(), "SubCategoryId", "SubCategoryName");
            if (ModelState.IsValid)
            {
                if (rec.ActualFile != null)
                {
                    if (rec.ActualFile.Length > 0)
                    {

                        string filename = rec.ActualFile.FileName;
                        string folderpath = Path.Combine(this.wbhenv.WebRootPath, "GreetingImages");
                        string uploadpath = Path.Combine(folderpath, filename);
                        FileStream fs = new FileStream(uploadpath, FileMode.Create);
                        rec.ActualFile.CopyTo(fs);
                        string logicalpath = Path.Combine("\\GreetingImages", filename);
                        rec.PhotoPath = logicalpath;
                    }
                }
                Int64 storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
                rec.StoreId = storeid;
                this.gcrepo.Add(rec);
                return RedirectToAction("Index");

            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {          
            
             
            var rec = this.gcrepo.GetByGreetingId(id);
            ViewBag.Cat = new SelectList(this.catgrepo.GetAll(), "CategoryID", "CategoryName", rec.CategoryID);
            ViewBag.SubCat = new SelectList(this.sbctgrepo.GetAll(), "SubCategoryId", "SubCategoryName", rec.SubCategoryId);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(GreetingCardVM rec)
        {
            ViewBag.Cat = new SelectList(this.catgrepo.GetAll(), "CategoryID", "CategoryName", rec.CategoryID);
            ViewBag.SubCat = new SelectList(this.sbctgrepo.GetAll(), "SubCategoryId", "SubCategoryName", rec.SubCategoryId);

            if (ModelState.IsValid)
            {
                if (rec.ActualFile != null)
                {
                    if (rec.ActualFile.Length > 0)
                    {

                        string filename = rec.ActualFile.FileName;
                        string folderpath = Path.Combine(this.wbhenv.WebRootPath, "GreetingImages");
                        string uploadpath = Path.Combine(folderpath, filename);
                        FileStream fs = new FileStream(uploadpath, FileMode.Create);
                        rec.ActualFile.CopyTo(fs);
                        string logicalpath = Path.Combine("\\GreetingImages", filename);
                        rec.PhotoPath = logicalpath;
                    }
                }
                Int64 storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
                rec.StoreId = storeid;

                this.gcrepo.Edit(rec);
                return RedirectToAction("Index");
            }
         return View(rec);
        }


        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            var rec = this.gcrepo.GetByGreetingId(id);
            ViewBag.Cat = new SelectList(this.catgrepo.GetAll(), "CategoryID", "CategoryName", rec.CategoryID);
            ViewBag.SubCat = new SelectList(this.sbctgrepo.GetAll(), "SubCategoryId", "SubCategoryName", rec.SubCategoryId);
            return View(rec);

        }

        [HttpGet]
        public IActionResult Details(Int64 id)
        {
            var rec = this.gcrepo.GetByGreetingId(id);
            ViewBag.Cat = new SelectList(this.catgrepo.GetAll(), "CategoryID", "CategoryName", rec.CategoryID);
            ViewBag.SubCat = new SelectList(this.sbctgrepo.GetAll(), "SubCategoryId", "SubCategoryName", rec.SubCategoryId);
            return View(rec);
        }
        public IActionResult GetSubCategoryJson(Int64 id)
        {
            var rec = this.sbctgrepo.GetSubCategoryByCategoryId(id);
            return Json(rec.ToList());
        }

    }
}
