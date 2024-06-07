using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    public class MyComplaintController : Controller
    {
        IOrder orepo;
        public MyComplaintController(IOrder orepo)
        {
            this.orepo = orepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ViewSolution(Int64 id)
        {
            var rec = this.orepo.GetSolutionByComplaintID(id);
            return View(rec);
        }

    }
}
