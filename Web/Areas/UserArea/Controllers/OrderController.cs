using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;
using System.Linq;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]

    public class OrderController : Controller
    {
        IOrder orepo;
        IDispatch drepo;
        public OrderController(IOrder orepo, IDispatch drepo)
        {
            this.orepo = orepo;
            this.drepo = drepo;
        }

        public IActionResult Index()
        {
            var userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            return View(this.orepo.GetAllOrderByUserID(userid));
        }
        public IActionResult viewdetails(Int64 id)
        {
            ViewBag.OrderId = id;
            var v = this.orepo.GetById(id);
            return View(v);
        }
        [HttpGet]
        public IActionResult RaisComplaint(Int64 id )
        {
            TempData["OrderId"]= id;
             
             
            return View();
        }
        [HttpPost]
        public IActionResult RaisComplaint(Complaint rec  )
        {
           
            if (ModelState.IsValid)
            {
                //rec.OrderId = id;
                //Int64 strid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
                var res = this.orepo.RaiseComplaint(rec);
                if (res.IsSuccess)
                {
                    TempData["Message"] = "Your Complaint Raise Suucessfully!";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Message = res.Message;
                }

            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Return(Int64 id)
        {
            TempData["OrderId"] = id;
            return View();
        }
        [HttpPost]
        public IActionResult Return(Return rec)
        {

            if (ModelState.IsValid)
            {
                //rec.OrderId = id;
                //Int64 strid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
                var res = this.orepo.RetunRequst(rec);
                if (res.IsSuccess)
                {
                    TempData["Message"] = "Your Product Return Suucessfully!";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Message = res.Message;
                }

            }
            return View(rec);
        }

    }
}
