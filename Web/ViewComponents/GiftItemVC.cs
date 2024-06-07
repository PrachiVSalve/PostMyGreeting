using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Repo.ViewModel;
using System.Drawing;

namespace Web.ViewComponents
{
    public class GiftItemVC:ViewComponent
    {
        IGiftItem grepo;
        ICategory crepo;
        ISubCategory screpo;
        public GiftItemVC(IGiftItem grepo, ICategory crepo, ISubCategory screpo)
        {
            this.grepo = grepo;
            this.crepo = crepo;
            this.screpo = screpo;
        }
        public IViewComponentResult Invoke(List<GiftItem> rec)
        {
            if (rec == null)
            {
                var res = this.grepo.GetAll();
                ViewBag.CategotyID = new SelectList(this.crepo.GetAll(), "CategoryID", "CategoryName");
                ViewBag.SubCategoryId = new SelectList(this.screpo.GetAll(), "SubCategoryId", "SubCategoryName");

                return View(res);
            }
            else
            ViewBag.CategoryID = new SelectList(this.crepo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.SubCategoryId = new SelectList(this.screpo.GetAll(), "SubCategoryId", "SubCategoryName");
            return View(rec);
        }
    }
}
