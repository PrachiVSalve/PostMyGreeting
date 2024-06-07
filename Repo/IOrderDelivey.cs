using Core;
using Repo.ViewModel;
using Repo.ViewModel.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IOrderDelivey
    {
        //void deliveryadd(OrderDeliveryVM rec);
        //Order AddOrder(Int64 UserID, Int64 storeid);
        //OrderDeliveryVM deliveryadd( Int64 userid,OrderDeliveryVM rec,Int64 storeid);
        OrderDeliveryVM deliveryadd( OrderDeliveryVM rec);
    }

}
