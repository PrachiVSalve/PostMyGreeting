//using Core;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.Identity.Client;
//using Repo;
//using Web.CustFilter;

//namespace Web.Areas.StoreArea.Controllers
//{
//    [Area("StoreArea")]
//    [StoreAuth]
//    public class OfferController : Controller
//    {

//        IOffer  ofrepo;
//        IStore srepo;
//        public OfferController(IOffer ofrepo,IStore srepo)
//        {
//            this.ofrepo = ofrepo;
//            this.srepo = srepo;
//        }
//        public IActionResult Index()
//        {
//            ViewBag.store = new SelectList(this.srepo.GetAll(), "StoreId", "StoreName");
//            var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
//            return View(this.ofrepo.GetAllByStoreID(storeid));
//        }
//        [HttpGet]
//        public IActionResult Create()
//        {
//            ViewBag.store = new SelectList(this.srepo.GetAll(), "StoreId", "StoreName");
//            return View();
//        }
//        [HttpPost]
//        public IActionResult Create(Offer rec)
//        {
//            ViewBag.store = new SelectList(this.srepo.GetAll(), "StoreId", "StoreName");
//            Int64 storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
//            rec.StoreId = storeid;
//            if (ModelState.IsValid)
//            {
                
//                this.ofrepo.Add(rec);
//                return RedirectToAction("Index");

//            }
             
//            return View(rec);
//        }
//        [HttpGet]
//        public IActionResult Edit(Int64 id)
//        {
           
//            var rec = this.ofrepo.GetById(id);
//            ViewBag.store = new SelectList(this.srepo.GetAll(), "StoreId", "StoreName",rec.StoreId);
//            return View(rec);
//        }
//        [HttpPost]
//        public IActionResult Edit(Offer rec)
//        {
//         if(ModelState.IsValid)
//            {
//                this.ofrepo.Edit(rec);
//                return RedirectToAction("Index");
//            }
//            ViewBag.store = new SelectList(this.srepo.GetAll(), "StoreId", "StoreName", rec.StoreId);
//            return View(rec);
//        }
//        [HttpGet]
//        public IActionResult Delete(Int64 id)
//        {
//            this.ofrepo.Delete(id);
//            return RedirectToAction("Index");
//        }
//    }
//}
