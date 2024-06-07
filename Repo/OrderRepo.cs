using Core;
using Entities;
 
using Repo.Enum;
using Repo.ViewModel;
using Repo.ViewModel.Profile;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class OrderRepo : GenRepo<Order>, IOrder
    {
        ProContext cntx;
        public OrderRepo(ProContext cntx) : base(cntx)
        {
            this.cntx = cntx;
        }

       

        public List<Order> GetAllByStoreID(long storeid)
        {
            var res = this.cntx.Orders.Where(p => p.StoreId == storeid).ToList();
            if (res != null)
            {
                var v = from t in this.cntx.Orders
                        where t.StoreId == storeid
                        where !(from t1 in this.cntx.Dispatch
                                select t1.OrderId).Contains(t.OrderId)

                        select t;
                return v.ToList();

            }
            else
                return res;
        }

        public List<Order> GetAllByUserID(long userid)
        {
            return this.cntx.Orders.Where(p => p.UserId == userid).ToList();
        }

        //public List<OrderComplaint> GetAllComplaints()
        //{
        //    return this.cc.OrderComplaints.ToList();
        //}

        public List<Complaint> GetAllSolvedComplaints(long storeid)
        {
            var res = this.cntx.Complaints.Where(p => p.Product.StoreId == storeid).ToList();
            if (res != null)
            {

                var v = from t in this.cntx.Complaints
                        join t1 in this.cntx.Solutions
                        on t.ComplaintId equals t1.ComplaintId
                        select t;
                return v.ToList();
            }else 
                return res;
        }
        public List<Complaint> GetAllUserSolvedComplaints(long userid)
        {
            var res = this.cntx.Complaints.Where(p => p.Product.StoreId == userid).ToList();
            if (res != null)
            {

                var v = from t in this.cntx.Complaints
                        join t1 in this.cntx.Solutions
                        on t.ComplaintId equals t1.ComplaintId
                        select t;
                return v.ToList();
            }
            else
                return res;
        }



        public List<Complaint> GetAllNewComplaints(long storeid)
        {
            var res = this.cntx.Complaints.Where(p => p.Product.StoreId == storeid).ToList();
            if (res != null)
            {

                var v = from t in this.cntx.Complaints
                        where t.Product.StoreId == storeid
                        where !(from t1 in this.cntx.Solutions
                                select t1.ComplaintId)
                                .Contains(t.ComplaintId)
                        select t;

                return v.ToList();
            }
            else
                return res;
        }

        public List<OrderDetails> GetOrderDetByUserID(long userid)
        {
            var v = from t in this.cntx.Orders
                    join t1 in this.cntx.OrderDetails
                    on t.OrderId equals t1.OrderId
                    where t.UserId == userid
                    select t1;

            return v.ToList();
        }

        public ProfileResultVM RaiseComplaint(Complaint rec )
        {
            ProfileResultVM res = new ProfileResultVM();
            try
            {

                //Complaint c = new Complaint();
                //c.CompliantDate = rec.CompliantDate;
                //c.OrderId = rec.OrderId;
                //c.ProductId = rec.ProductId;
                //c.Product.StoreId =rec.Product.StoreId;
                rec.CompliantDate = DateTime.Now;
                this.cntx.Complaints.Add(rec);
                    this.cntx.SaveChanges();
                    res.IsSuccess = true;
                    res.Message = " Your Complaint Raised!";
                    return res;
                
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.ToString();
            }
            return res;
        }

        public ProfileResultVM AddComplaintSolution(Solution rec)
        {

            ProfileResultVM res = new ProfileResultVM();
            try
            {
                rec.SolutionDate = DateTime.Now;
                this.cntx.Solutions.Add(rec);
                this.cntx.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Solution Added!";
                return res;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.ToString();
            }

            return res;
        }

        public Solution GetSolutionByComplaintID(long ComplaintId)
        {
            return this.cntx.Solutions.FirstOrDefault(p => p.ComplaintId== ComplaintId);
        }
        public List<CartVM> GetAllByOrderId(long OrderId)
        {
            var v = this.cntx.Orders.Where(p => p.OrderId == OrderId);
            if (v.Any())
            {
                var res = (from t in this.cntx.GiftItems
                           join t1 in this.cntx.Products
                           on t.ProductId equals t1.ProductId
                           join t2 in this.cntx.Orders
                           on t1.StoreId equals t2.StoreId
                           join t3 in this.cntx.OrderDetails
                           on t2.OrderId equals t3.OrderId
                           where t3.OrderId == OrderId && t2.OrderId == t3.OrderId && t3.ProductId == t1.ProductId

                           select new CartVM
                           {
                               OrderId = t2.OrderId,
                               Price = t1.Price,
                               Qty = t3.Qty,
                               UserId = t2.UserId,
                               StoreId = t2.StoreId,
                               ProductId = t1.ProductId,
                               ProductName=t.GiftItemTitle,//complaint
                               PhotoPath = t.PhotoPath,
                               GiftItemTitle = t.GiftItemTitle,

                           }).Distinct();
                return res.ToList();
            }
            else
            {
                return new List<CartVM>();
            }

        }
        public List<CartVM> GetGreetingByOrderId(long OrderId)
        { var v= this.cntx.Orders.Where(p=>p.OrderId== OrderId);
            if (v.Any())
            {
                var res = (from t in this.cntx.GreetingCards
                           join t1 in this.cntx.Products
                           on t.ProductId equals t1.ProductId
                           join t2 in this.cntx.Orders
                           on t1.StoreId equals t2.StoreId
                           join t3 in this.cntx.OrderDetails
                           on t2.OrderId equals t3.OrderId
                           where t3.OrderId == OrderId && t2.OrderId==t3.OrderId && t3.ProductId==t1.ProductId
                           select new CartVM
                           {
                               OrderId = t2.OrderId,
                               Price = t1.Price,
                               Qty = t3.Qty,
                               UserId = t2.UserId,
                               StoreId = t2.StoreId,
                               ProductId = t1.ProductId,
                               ProductName=t.CardTitle,//complaint
                               PhotoPath = t.PhotoPath,
                               CardTitle = t.CardTitle,

                           }).Distinct();
                return res.ToList();
            }
            else
            {
                return new List<CartVM>();
            }

        }

        public List<Return> GetReturn(long storeid)
        {
            var v = from t in this.cntx.Returns
                    where !(from t1 in this.cntx.Refunds 
                            select t1.RefundId)
                            .Contains(t.ReturnId)
                    select t;

            return v.ToList();
        }
        //public List<ReturnVM> GetRefund(long storeid)
        //{
        //    var v = from t in this.cntx.Returns
        //            where !(from t1 in this.cntx.Refunds
        //                    select t1.RefundId)
        //                    .Contains(t.ReturnId)
        //            select t;

        //    return v.ToList();
        //}
        public List<ReturnVM> GetAllByRefund(long storeid)
        {
            var re = this.cntx.Returns.Where(p => p.Order.StoreId == storeid).ToList();
            if (re != null)
            {
                var s = from t1 in this.cntx.Returns
                        join t2 in this.cntx.Refunds
                        on t1.ReturnId equals t2.ReturnId
                        join t4 in this.cntx.Products
                        on t1.ProductId equals t4.ProductId
                        where t1.Order.StoreId == storeid
                        select new ReturnVM
                        {
                            ReturnId = t1.ReturnId,
                            ReturnDate = t1.ReturnDate,
                            ReturnReasion = t1.ReturnReasion,
                            OrderId = t1.OrderId,
                            ProductId = t1.ProductId,
                            ProductType = t4.ProductType,
                             GiftItemTitle= t4.GiftItems.FirstOrDefault().GiftItemTitle,
                            CardTitle = t4.GreetingCards.FirstOrDefault().CardTitle,
                             
                        };

                return s.ToList();

            }
            else
                return null;
        }
        public ProfileResultVM RetunRequst(Return rec)
        {
            ProfileResultVM res = new ProfileResultVM();
            try
            {

                //Complaint c = new Complaint();
                //c.CompliantDate = rec.CompliantDate;
                //c.OrderId = rec.OrderId;
                //c.ProductId = rec.ProductId;
                //c.Product.StoreId =rec.Product.StoreId;
                rec.ReturnDate = DateTime.Now;
                this.cntx.Returns.Add(rec);
                this.cntx.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Return SuccessFully!";
                return res;

            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.ToString();
            }
            return res;
        }

        public ProfileResultVM AddRefund(Refund rec)
        {
            ProfileResultVM res = new ProfileResultVM();
            try
            {
                rec.RefundDate = DateTime.Now;
                this.cntx.Refunds.Add(rec);
                this.cntx.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Refund Successfully!";
                return res;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.ToString();
            }

            return res;
        }

        public List<Order> GetAllOrderByUserID(long userid)
        {
            var res = this.cntx.Orders.Where(p => p.UserId == userid).ToList();
            if (res != null)
            {
                var v = from t in this.cntx.Orders
                        where t.UserId==userid 
                        where !(from t1 in this.cntx.Dispatch
                                select t1.OrderId).Contains(t.OrderId)

                        select t;
                return v.ToList();

            }
            else
                return res;
        }
        public List<Payment> GetCollections(string r, string p, long storeid)
        {
            DateTime fromDate = DateTime.Parse(r);
            DateTime toDate = DateTime.Parse(p);

            var py = from t1 in this.cntx.Payment
                    join t2 in this.cntx.Orders
                    on t1.OrderId equals t2.OrderId
                    where t2.StoreId == storeid
                    where t1.PaymentDate >= fromDate && t1.PaymentDate <= toDate
                    select t1;

            return py.ToList();
        }
        public List<Order> GetPendings(string r, string p, long storeid)
        {
            DateTime fromDate = DateTime.Parse(r);
            DateTime toDate = DateTime.Parse(p);

            var pd = from t1 in this.cntx.Orders
                    join t2 in this.cntx.Dispatch
                    on t1.OrderId equals t2.OrderId
                    into g
                    from t2 in g.DefaultIfEmpty()
                    where t1.StoreId == storeid
                    where ((t1.OrderDate >= fromDate && t1.OrderDate <= toDate) && t1.OrderId != t2.OrderId)
                    select t1;

            return pd.ToList();

        }
        public List<ReturnVM> GetRefunds(string r, string p, long storeid)
        {
            DateTime fromDate = DateTime.Parse(r);
            DateTime toDate = DateTime.Parse(p);
            var v = from t1 in this.cntx.Refunds
                    join t2 in this.cntx.Returns
                    on t1.ReturnId equals t2.ReturnId
                    join t3 in this.cntx.Products
                    on t2.ProductId equals t3.ProductId
                    where t2.Order.StoreId == storeid
                    where t1.RefundDate >= fromDate && t1.RefundDate <= toDate
                    select new ReturnVM
                    {
                        OrderId = t2.OrderId,
                        ProductType = t2.Product.ProductType,
                        ProductId = t1.Return.ProductId,
                     GiftItemTitle = t3.GiftItems.FirstOrDefault().GiftItemTitle,
                        CardTitle = t3.GreetingCards.FirstOrDefault().CardTitle,
                         
                        Price = t3.Price,
                        RefundDate = t1.RefundDate,
                        RefundAmount = t1.RefundAmount
                    };
            return v.ToList();
        }
    }
}
