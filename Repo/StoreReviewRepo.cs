using Core;
using Entities;
using Repo.ViewModel;
using Repo.ViewModel.Change_Password;
using Repo.ViewModel.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class StoreReviewRepo:GenRepo<StoreReview>,IReview
    {
        ProContext cntx;
        public StoreReviewRepo(ProContext cntx):base(cntx)
        {
            this.cntx=cntx;
        }
        public List<StoreReviewVM> GetByStoreId(long userid)
        {
            var v = this.cntx.Orders.Where(p => p.UserId == userid).Select(p => p.StoreId).ToList();

            if (v != null)
            {

                var s = (from t1 in this.cntx.Orders
                         join t2 in this.cntx.OrderDetails
                         on t1.OrderId equals t2.OrderId
                         join t3 in this.cntx.Products
                         on t2.ProductId equals t3.ProductId
                         where t1.UserId == userid && t1.StoreId == t3.StoreId
                         select new StoreReviewVM
                         {
                             StoreId = t1.StoreId,
                             StoreName = t1.Store.StoreName

                         }).Distinct();

                return s.ToList();
            }
            else
                return null;
        }
        public ProfileResultVM AddStoreReview(StoreReviewVM rec)
        {
            ProfileResultVM res = new ProfileResultVM();
             
            {
                try
                {
                    StoreReview c = new StoreReview();
                    c.Review = rec.Review;
                    c.StoreId = rec.StoreId;
                   c.UserId = rec.UserId;
                    c.Rating = rec.Rating;
                    c.ReviewDate= rec.ReviewDate;
                    this.cntx.StoreReviews.Add(c);
                    this.cntx.SaveChanges();
                    res.IsSuccess = true;
                    res.Message = "Your Store Review Added Successfully!!!";
                    return res;
                }
                catch (Exception ex)
                {
                    res.IsSuccess = false;
                    res.Message = ex.Message.ToString();
                }
            }
            return res;
        }
        public List<StoreReview> GetByAllStoresId(long userid)
        {
            return this.cntx.StoreReviews.ToList();
        }

    }
}
