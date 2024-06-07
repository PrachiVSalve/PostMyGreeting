using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;
using Web.CustFilter;

namespace Web.Areas.StoreArea.Controllers
{
    [Area("StoreArea")]
    [StoreAuth]
    public class ComplaintsController : Controller
    {
        IOrder orepo;
        public ComplaintsController(IOrder orepo)
        {
            this.orepo = orepo;
        }

        public IActionResult Index()
        {
            var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
            return View();
        }
        [HttpGet]
        public IActionResult AddSolution(Int64 id)
        {
            ViewBag.ComplaintId = id;
            return View();
        }


        [HttpPost]
        public IActionResult AddSolution(Solution rec)
        {
            if (ModelState.IsValid)
            {
                var res = this.orepo.AddComplaintSolution(rec);
                if (res.IsSuccess)
                {
                    TempData["Message"] = res.Message;
                    return RedirectToAction("Index");
                }
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }


        [HttpGet]
        public IActionResult ViewSolution(Int64 id)
        {
            var rec = this.orepo.GetSolutionByComplaintID(id);
            return View(rec);
        }

    }
}
