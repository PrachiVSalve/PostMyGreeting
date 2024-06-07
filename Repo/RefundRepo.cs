using Core;
using Entities;
using Repo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class RefundRepo:GenRepo<Refund>,IRefund
    {
        ProContext cntx;
        public RefundRepo(ProContext cntx):base(cntx) 
        {
            this.cntx = cntx;
        }
        public List<ReturnVM> GetAllByUserRefund(long userid)
        {
            var re = this.cntx.Returns.Where(p => p.Order.UserId == userid).ToList();
            if (re != null)
            {
                var s = from t1 in this.cntx.Returns
                        join t2 in this.cntx.Refunds
                        on t1.ReturnId equals t2.ReturnId
                        join t4 in this.cntx.Products
                        on t1.ProductId equals t4.ProductId
                        where t1.Order.UserId == userid
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
                             
                        };

                return s.ToList();

            }
            else
                return null;
        }
    }
}
