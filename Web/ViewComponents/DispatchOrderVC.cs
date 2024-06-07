using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class DispatchOrderVC:ViewComponent
    {
        IDispatch drepo;
        public DispatchOrderVC(IDispatch drepo)
        {
            this.drepo = drepo;
        }
        public IViewComponentResult Invoke(Int64 storeid)
        {
            var v = this.drepo.GetAllByOrderID(storeid);
            return View(v.ToList());
        }
    }
}
