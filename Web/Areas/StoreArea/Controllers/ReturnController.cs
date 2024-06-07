using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;
using Repo.ViewModel;
using Web.CustFilter;

namespace Web.Areas.StoreArea.Controllers
{
    [Area("StoreArea")]
    [StoreAuth]
    public class ReturnController : Controller
    {
        IOrder orepo;
        IReturn rrepo;

        public ReturnController(IOrder orepo, IReturn rrepo)
        {
            this.orepo = orepo;
            this.rrepo = rrepo;
        }
        public IActionResult Index()
        {
            var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
            return View(storeid);
        }
        [HttpGet]
        public IActionResult ViewReturn(Int64 id)
        {
            ViewBag.ReturnId = id;
            return View();
        }

        [HttpPost]
        public IActionResult ViewReturn(Refund rec)
        {
            if (ModelState.IsValid)
            {
                var res = this.orepo.AddRefund(rec);
                if (res.IsSuccess)
                {
                    TempData["Message"] = res.Message;
                    return RedirectToAction("Index");
                }
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }
        public IActionResult ReturnDetails(Int64 id)
        {
            ViewBag.ReturnId = id;
            var v = this.rrepo.ReturnDet(id);
            return View(v);
        }
        [HttpPost]
        public IActionResult ReturnDetails(ReturnVM rec, Int64 id)
        {
            if (ModelState.IsValid)
            {
                var v = this.rrepo.AddReturns(rec);
                TempData["Message"] = v.Message;
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        public IActionResult viewdetails(Int64 id)
        {
            ViewBag.OrderId = id;
            var v = this.rrepo.GetRefundDetails(id);
            return View(v);
        }



    }
}
