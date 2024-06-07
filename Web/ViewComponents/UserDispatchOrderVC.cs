using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class UserDispatchOrderVC:ViewComponent
    {
        IDispatch drepo;
        public UserDispatchOrderVC(IDispatch drepo)
        {
            this.drepo = drepo;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
            var v = this.drepo.GetAllByUserOrderID(userid);
            return View(v.ToList());
        }
    }
}
