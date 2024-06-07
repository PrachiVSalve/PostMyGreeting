using Core;
using Entities;
using Repo.ViewModel;
using Repo.ViewModel.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repo
{
    public class OrderdeliveryRepo : GenRepo<OrderDelivery>, IOrderDelivey
    {
        ProContext cntx;
        public OrderdeliveryRepo(ProContext cntx):base (cntx)
        {
            this.cntx = cntx;
        }

        //public Order AddOrder(Int64 UserID, Int64 storeid)
        //{
        //    var StoreId = this.cntx.Carts.Where(p => p.UserId == UserID).Select(p=>p.StoreId).FirstOrDefault();

        //    Order od = new Order();
        //    od.OrderDate = DateTime.Now;
        //    od.StoreId = StoreId;
        //    od.UserId = UserID;
        //    this.cntx.Orders.Add(od);
        //    this.cntx.SaveChanges();
        //    return od;
        //}

        public OrderDeliveryVM deliveryadd(OrderDeliveryVM rec)
        { 
            OrderDeliveryVM odv= new OrderDeliveryVM();
            odv.DeliverToPersonName=rec.DeliverToPersonName;
            odv.DeliveryAddress=rec.DeliveryAddress;
            odv.PinCode=rec.PinCode;
            odv.ContactNo=rec.ContactNo;    
            odv.CityId=rec.CityId;
            return odv;
         
        }
        
    }



}

 
   