using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Repo.ViewModel;
using System.Drawing;

namespace Web.ViewComponents
{
    public class GreetingVC:ViewComponent
    {
        IGreetingCard gcrepo;
        
        public GreetingVC(IGreetingCard gcrepo )
        {
            this.gcrepo = gcrepo;
           
        }
        public IViewComponentResult Invoke(List<GreetingCard> rec)
        {
            if (rec == null)
            {
                var v = this.gcrepo.GetAll();
                return View(v);
            }
            else
                return View(rec);
        }
    }
}
