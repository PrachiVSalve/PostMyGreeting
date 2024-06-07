using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using System.Reflection.Metadata.Ecma335;
using Web.CustFilter;

namespace Web.Areas.StoreArea.Controllers
{
    [Area("StoreArea")]
    [StoreAuth]
    public class OrderController : Controller
    {
        IOrder orepo;
        IDispatch drepo;
        IdispatchAgency darepo;
        
        public OrderController(IOrder orepo,IDispatch drepo,IdispatchAgency darepo)
        {
            this.orepo = orepo;
            this.drepo = drepo;
            this.darepo = darepo;
        }
        public IActionResult Index()
        {
            var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
            return View(this.orepo.GetAllByStoreID(storeid));
             
        }
        public IActionResult NewOrder()
        {
            var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
            return View(storeid);
        }
        public IActionResult viewdispatchdetails(Int64 id)
        {
            ViewBag.OrderId=id;
            var v=this.orepo.GetById(id);
            return View(v);
        }
        [HttpGet]
        public IActionResult DispatchOrder(Int64 id)
        {
            ViewBag.DispatchAgencyId = new SelectList(this.darepo.GetAll(), "DispatchAgencyId", "AgencyName");
            TempData["OrderId"] = id;
            return View();
        }
        public IActionResult DispatchOrder(Dispatch rec,Int64 id)
        {
            ViewBag.DispatchAgencyId = new SelectList(this.darepo.GetAll(), "DispatchAgencyId", "AgencyName");
            if (ModelState.IsValid)
            {
               
                rec.OrderId = Convert.ToInt64(id);
                rec.DispatchDate = DateTime.Now;
                this.drepo.Add(rec);
                TempData["Message"] = "Your Order Dispatch Suucessfully!";
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        public IActionResult viewdetails(Int64 id)
        {
          ViewBag.OrderId = id;
            var v = this.orepo.GetById(id);
            return View(v);
        }
    }
}
