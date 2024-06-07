using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class UserRefundVC:ViewComponent
    {
        IRefund rfrepo;
        public UserRefundVC(IRefund rfrepo)
        {
            this.rfrepo = rfrepo;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
            var v = this.rfrepo.GetAllByUserRefund(userid);
            return View(v.ToList());
        }
    }
}
