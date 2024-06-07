using Microsoft.AspNetCore.Mvc;
using Repo;
using Web.CustFilter;

namespace Web.Areas.StoreArea.Controllers
{
    [Area("StoreArea")]
    [StoreAuth]
    public class PendingReportController : Controller
    {
        IOrder orepo;
        public PendingReportController(IOrder orepo)
        {
            this.orepo = orepo;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
       public IActionResult PendingReport(string r,string p)
        {
            var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
            var v = this.orepo.GetPendings(r, p,storeid);
            return View(v);
        }
       
    }
}
