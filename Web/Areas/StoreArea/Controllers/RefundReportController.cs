using Microsoft.AspNetCore.Mvc;
using Repo;
using Web.CustFilter;


namespace Web.Areas.StoreArea.Controllers
{
    [Area("StoreArea")]
    [StoreAuth]
    public class RefundReportController : Controller
    {
        IOrder orepo;
        public RefundReportController(IOrder orepo)
        {
             this.orepo = orepo;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
       public IActionResult RefundReport(string r,string  p)
        {
            var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
            var v = this.orepo.GetRefunds(r,p,storeid);
            return View(v);
        }
       
    }
}
