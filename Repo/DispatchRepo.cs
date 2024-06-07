using Core;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class DispatchRepo : GenRepo<Dispatch>, IDispatch
    {
        ProContext cntx;
        public DispatchRepo(ProContext cntx):base(cntx)
        {
            this.cntx = cntx;
        }
        public List<Order> GetAllByOrderID(long storeid)
        {
            var res = this.cntx.Orders.Where(p => p.StoreId == storeid).ToList();
            if (res != null)
            {
                var v = from t in this.cntx.Orders
                        join t1 in this.cntx.Dispatch
                        on t.OrderId equals t1.OrderId
                        where t.StoreId == storeid
                        select t;
                return v.ToList();
            }
            else
                return res;
        }

        public List<Order> GetAllByUserOrderID(long userid)
        {
            var res = this.cntx.Orders.Where(p => p.UserId == userid).ToList();
            if (res != null)
            {
                var v = from t in this.cntx.Orders
                        join t1 in this.cntx.Dispatch
                        on t.OrderId equals t1.OrderId
                        where t.UserId == userid
                        select t;
                return v.ToList();
            }
            else
                return res;
        }
    }

}
