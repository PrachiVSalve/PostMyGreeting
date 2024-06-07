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
    public class ReturnRepo : GenRepo<Return>, IReturn
    {
        ProContext cntx;
        public ReturnRepo(ProContext cntx):base(cntx)  
        {
            this.cntx = cntx;
        }
        public ReturnVM ReturnDet(long returnid)
        {
            var v = (from t1 in this.cntx.Returns
                     join t2 in this.cntx.Refunds
                     on t1.ReturnId equals t2.ReturnId
                     into g
                     from t2 in g.DefaultIfEmpty()
                     join t4 in this.cntx.Products
                     on t1.ProductId equals t4.ProductId
                     where t1.ReturnId == returnid
                     select new ReturnVM
                     {
                         ReturnId = t1.ReturnId,
                         ReturnDate = t1.ReturnDate,
                          ReturnReasion = t1.ReturnReasion,
                         OrderId = t1.OrderId,
                         ProductId = t1.ProductId,
                         ProductType = t4.ProductType,
                         GiftItemTitle = t4.GiftItems.FirstOrDefault().GiftItemTitle,
                         CardTitle = t4.GreetingCards.FirstOrDefault().CardTitle,
                          
                         Price = t4.Price
                     }).FirstOrDefault();

            return v;
        }
        public ProfileResultVM AddReturns(ReturnVM rec)
        {
            ProfileResultVM res = new  ProfileResultVM();
            try
            {
                Refund refund = new Refund();
                refund.ReturnId = rec.ReturnId;
                refund.RefundDate = DateTime.Now;
                refund.RefundAmount = rec.Price;
                this.cntx.Refunds.Add(refund);
                this.cntx.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Product Refunded Successfully!";

            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }
            return res;
        }
        public ReturnVM GetRefundDetails(long returnid)
        {
            var v = (from t in this.cntx.Refunds
                     where t.ReturnId == returnid
                     select new ReturnVM
                     {
                         ReturnId = t.ReturnId,
                         RefundDate = t.RefundDate,
                         RefundAmount = t.RefundAmount,

                     }).FirstOrDefault();
            return v;

        }
    }
}
