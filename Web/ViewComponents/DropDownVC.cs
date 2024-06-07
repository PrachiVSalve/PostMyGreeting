using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Repo.ViewModel;
using System.Drawing;

namespace Web.ViewComponents
{
    public class DropDownVC:ViewComponent
    {
        ICategory crepo;
        ISubCategory sbcrepo;
        public DropDownVC( ISubCategory sbcrepo,ICategory crepo)
        {
            this.crepo = crepo;
            this.sbcrepo = sbcrepo;
        }
        public IViewComponentResult Invoke(Int64 id)
        {
            ViewBag.CategotyID = new SelectList(this.crepo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.SubCategoryId = new SelectList(this.sbcrepo.GetAll(), "SubCategoryId", "SubCategoryName");
            return View();
        }


    }
}
