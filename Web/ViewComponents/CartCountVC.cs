using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Repo.ViewModel;
using System.Drawing;

namespace Web.ViewComponents
{
    public class CartCountVC:ViewComponent
    {
        ICart crepo;
        public CartCountVC(ICart crepo)
        {
            this.crepo = crepo;
        }
        public IViewComponentResult Invoke(Int64 userid)
        {
            var cnt = this.crepo.GetCartCount(userid);
            return View(cnt);
        }


    }
}
