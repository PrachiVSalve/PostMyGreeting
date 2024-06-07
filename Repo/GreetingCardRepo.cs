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
    public class GreetingCardRepo : GenRepo<GreetingCard>, IGreetingCard
    {
        ProContext cntx;
        public GreetingCardRepo(ProContext cntx) : base(cntx)
        {
            this.cntx = cntx;
        }

        public void Add(GreetingCardVM rec)
        {
             

            GreetingCard gc= new GreetingCard();
            gc.ProductId = rec.ProductId;
            
            gc.SubCategoryId = rec.SubCategoryId;
            gc.CardTitle = rec.CardTitle;
            gc.CardDescription = rec.CardDescription;
            gc.DesignerName = rec.DesignerName;
            //gc.IsDigital = rec.IsDigital;
            gc.Product.Price = rec.Price;
            gc.Product.ProductType = rec.ProductType;
            gc.PhotoPath = rec.PhotoPath;
            gc.ActualFile= rec.ActualFile;
            gc.Product.StoreId = rec.StoreId;
            this.cntx.GreetingCards.Add(gc);
            this.cntx.SaveChanges();
 
        }

        public void DeleteGP(GreetingCardVM rec)
        {
            throw new NotImplementedException();
        }

        //public void DeleteGP(GiftItemVM rec)
        //{
        //    GiftItem g = new GiftItem();
        //    g.ProductId = rec.ProductId;
        //    g.Product.StoreId = rec.StoreId;
        //    g.SubCategoryId = rec.SubCategoryId;
        //    g.GiftItemDescription = rec.GiftItemDescription;
        //    g.PhotoPath = rec.PhotoPath;
        //    g.Product.Price = rec.Price;
        //    g.Product.ProductType = rec.ProductType;
        //    g.GiftItemTitle = rec.GiftItemTitle;
        //    g.ActualFile = rec.ActualFile;
        //    this.cntx.GiftItems.Remove(g);
        //    this.cntx.SaveChanges();
        //}


        public void Edit(GreetingCardVM rec)
        {
            GreetingCard gc = this.cntx.GreetingCards.Find(rec.GreetingCardId);
            gc.ProductId = rec.ProductId;
            gc.Product.StoreId = rec.StoreId;
            gc.SubCategoryId = rec.SubCategoryId;
            gc.CardTitle = rec.CardTitle;
            gc.CardDescription = rec.CardDescription;
            gc.DesignerName = rec.DesignerName;
            gc.IsDigital = rec.IsDigital;
            gc.Product.Price = rec.Price;
            gc.Product.ProductType = rec.ProductType;
            gc.PhotoPath = rec.PhotoPath;
            gc.ActualFile = rec.ActualFile;

            this.cntx.SaveChanges();
        }

        public GreetingCardVM GetByGreetingId(long id)
        {
            var rec = (from t in this.cntx.GreetingCards
                       join t1 in this.cntx.Products
                       on t.ProductId equals t1.ProductId
                       join t2 in this.cntx.SubCategories
                       on t.SubCategoryId equals t2.SubCategoryId
                       where t.GreetingCardId == id
                       select new GreetingCardVM
                       {
                           GreetingCardId=t.GreetingCardId,
                           ProductId = t1.ProductId,
                           Price= t1.Price,
                           ProductType = t1.ProductType,
                           //StoreId=t1.StoreId,
                           SubCategoryId = t.SubCategoryId,
                           SubCategoryName=t2.SubCategoryName,
                           CategoryID=t2.CategoryID,
                           CategoryName=t2.Category.CategoryName,
                           CardTitle=t.CardTitle,
                           CardDescription=t.CardDescription,
                           DesignerName=t.DesignerName,
                           IsDigital=t.IsDigital,
                           PhotoPath = t.PhotoPath,
                           ActualFile = t.ActualFile,
                       }).FirstOrDefault();
            return rec;

        }
        public List<GreetingCard> SearchByProductType(long protype = 0, long subcat = 0)
        {
            if (protype == 0 && subcat == 0)
            {

                return this.cntx.GreetingCards.ToList();

            }
            if (protype != 0 && subcat != 0)
            {
                return this.cntx.GreetingCards.Where(p => p.Product.ProductType == protype && p.SubCategoryId == subcat).ToList();
            }

            return this.cntx.GreetingCards.ToList();

        }
        public List<GreetingCard> GetAllByStoreID(long storeid)
        {
            return this.cntx.GreetingCards.Where(p => p.Product.StoreId == storeid).ToList();
        }


    }
}
