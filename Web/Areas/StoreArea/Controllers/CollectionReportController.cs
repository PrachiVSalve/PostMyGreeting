using Microsoft.AspNetCore.Mvc;
using Repo;
using Web.CustFilter;


namespace Web.Areas.StoreArea.Controllers
{
    [Area("StoreArea")]
    [StoreAuth]
    public class CollectionReportController : Controller
    {
        IOrder orepo;
        public CollectionReportController(IOrder orepo)
        {
             this.orepo = orepo;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
       public IActionResult Collection(string r,string  p)
        {
            var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreID"));
            var v = this.orepo.GetCollections(r,p,storeid);
            return View(v);
        }
       
    }
}
