using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    public class MyReturnController : Controller
    {
        IReturn rrepo;
        public MyReturnController(IReturn rrepo)
        {
            this.rrepo = rrepo;
        }

        public IActionResult Index()
        {
            var userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            return View(userid);
        }
        public IActionResult RefundDetails(Int64 id)
        {
            var v = this.rrepo.GetRefundDetails(id);
            return View(v);
        }
        public IActionResult viewdetails(Int64 id)
        {
            ViewBag.OrderId = id;
            var v = this.rrepo.GetRefundDetails(id);
            return View(v);
        }

    }
}
