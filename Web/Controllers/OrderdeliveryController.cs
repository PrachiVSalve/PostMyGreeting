using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo.ViewModel;
using Repo;
using Core;
using System;
using Newtonsoft.Json;

namespace Web.Controllers
{
    public class OrderdeliveryController : Controller
    {
        IOrderDelivey odrepo;
        ICity ctrepo;
        IState srepo;
        ICountry crepo;
        IOrder orepo;
        public OrderdeliveryController(IOrderDelivey odrepo, ICity ctrepo, IState srepo, ICountry crepo, IOrder orepo)
        {
            this.odrepo = odrepo;
            this.ctrepo = ctrepo;
            this.srepo = srepo;
            this.crepo = crepo;
            this.orepo = orepo;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DeliveryAddress( )
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
           
            ViewBag.Countrys = new SelectList(this.crepo.GetAll(), "CountryId", "CountryName");
            ViewBag.State = new SelectList(this.srepo.GetAll(), "StateId", "StateName");
            ViewBag.City = new SelectList(this.ctrepo.GetAll(), "CityId", "CityName");
            return View();
        }
        [HttpPost]
        public IActionResult DeliveryAddress(OrderDeliveryVM rec)
        {
            
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            Int64 storeid= Convert.ToInt64(HttpContext.Session.GetString("StoreID"));

            ViewBag.Countrys = new SelectList(this.crepo.GetAll(), "CountryId", "CountryName");
            ViewBag.State = new SelectList(this.srepo.GetAll(), "StateId", "StateName");
            ViewBag.City = new SelectList(this.ctrepo.GetAll(), "CityId", "CityName");
            
            //var addOrder = this.odrepo.AddOrder(userid,storeid);
            //Int64 OrderID = addOrder.OrderId;
            //TempData["OrderID"] = OrderID.ToString();
       
         //   var res = this.odrepo.deliveryadd(rec);
            
            HttpContext.Session.SetString("DeliverToPersonName",rec.DeliverToPersonName);
            HttpContext.Session.SetString("DeliveryAddress", rec.DeliveryAddress);
            HttpContext.Session.SetString("PinCode", rec.PinCode);
            HttpContext.Session.SetString("ContactNo", rec.ContactNo);
            HttpContext.Session.SetString("CityId", rec.CityId.ToString());


            return RedirectToAction("Index");
            
            
        }
    }
}
