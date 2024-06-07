using Core;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repo.ViewModel;
using Repo.ViewModel.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class GiftItemRepo : GenRepo<GiftItem>, IGiftItem
    {
        ProContext cntx;
        public GiftItemRepo(ProContext cntx) : base(cntx)
        {
            this.cntx = cntx;
        }

        public void Add(GiftItemVM rec)
        {


            GiftItem g = new GiftItem();
            g.ProductId = rec.ProductId;
            g.Product.StoreId = rec.StoreId;
            g.SubCategoryId = rec.SubCategoryId;
            g.GiftItemDescription = rec.GiftItemDescription;
            g.PhotoPath = rec.PhotoPath;
            g.Product.Price = rec.Price;
            g.Product.ProductType = rec.ProductType;
            g.GiftItemTitle = rec.GiftItemTitle;
            g.ActualFile = rec.ActualFile;
            this.cntx.GiftItems.Add(g);
            this.cntx.SaveChanges();
        }

        public void DeleteGP(GiftItemVM rec)
        {
            var prod = this.cntx.Products.Find(rec.ProductId);
            prod.StoreId = rec.StoreId;
            prod.ProductType = rec.ProductType;
            prod.Price = rec.Price;
            this.cntx.Products.Remove(prod);
            var gift = this.cntx.GiftItems.Find(rec.GiftItemId);
            gift.ProductId = rec.ProductId;
            gift.Product.Price = rec.Price;
            gift.Product.ProductType = rec.ProductType;
            gift.GiftItemTitle = rec.GiftItemTitle;
            gift.Product.StoreId = rec.StoreId;
            gift.GiftItemDescription = rec.GiftItemDescription;
            gift.PhotoPath = rec.PhotoPath;
            gift.ActualFile = rec.ActualFile;
            this.cntx.GiftItems.Remove(gift); this.cntx.SaveChanges();
        }





        public void Edit(GiftItemVM rec)
        {
            GiftItem g = this.cntx.GiftItems.Find(rec.GiftItemId);
            g.ProductId = rec.ProductId;
            g.Product.StoreId = rec.StoreId;
            rec.ProductType = rec.ProductType;
            g.Product.ProductType = rec.ProductType;
            g.Product.Price = rec.Price;
            g.SubCategoryId = rec.SubCategoryId;
            g.SubCategory.CategoryID = rec.CategoryID;
            g.GiftItemTitle = rec.GiftItemTitle;
            g.GiftItemDescription = rec.GiftItemDescription;
            g.PhotoPath = rec.PhotoPath;
            g.ActualFile = rec.ActualFile;


            this.cntx.SaveChanges();
        }

        public GiftItemVM GetByGIftId(long id)
        {
            var rec = (from t in this.cntx.GiftItems
                       join t1 in this.cntx.Products
                       on t.ProductId equals t1.ProductId
                       join t2 in this.cntx.SubCategories
                       on t.SubCategoryId equals t2.SubCategoryId
                       where t.GiftItemId == id
                       select new GiftItemVM
                       {
                           GiftItemId = t.GiftItemId,
                           ProductId = t1.ProductId,
                           Price = t1.Price,
                           ProductType = t1.ProductType,
                           StoreId = t1.StoreId,
                           SubCategoryId = t2.SubCategoryId,
                           SubCategoryName = t2.SubCategoryName,
                           CategoryName = t2.Category.CategoryName,
                           CategoryID = t2.CategoryID,
                           GiftItemTitle = t.GiftItemTitle,
                           GiftItemDescription = t.GiftItemDescription,
                           PhotoPath = t.PhotoPath,
                           ActualFile = t.ActualFile,
                       }).FirstOrDefault();
            return rec;

        }

        public List<GiftItem> SearchByProductType(long protype = 0, long subcat = 0)
        {
            if (protype == 0 && subcat == 0)
            {

                return this.cntx.GiftItems.ToList();

            }
            else if (protype != 0 && subcat != 0)
            {
                return this.cntx.GiftItems.Where(p => p.Product.ProductType == protype && p.SubCategoryId == subcat).ToList();
            }

            return this.cntx.GiftItems.ToList();

        }
        public List<GiftItem> GetAllByStoreID(long storeid)
        {
            return this.cntx.GiftItems.Where(p => p.Product.StoreId == storeid).ToList();
        }


    }
}
