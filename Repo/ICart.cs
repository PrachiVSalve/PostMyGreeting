
using Repo.ViewModel.Profile;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repo.ViewModel;

namespace Repo
{
    public interface ICart:IGeneric<Cart>
    {
        CartVM AddToCart(Int64 gfid,Int64 storeid,Int64 userid);  
        List<CartVM>GetAllByUserId(Int64 userid);
        List<CartVM> GetGreetingByUserId(Int64 userid);
        int GetCartCount(Int64 userid);
        CartVM AddToGreetingCart(Int64 gcid, Int64 storeid, Int64 userid);
        //void DeleteCO(Int64 CartId,Int64 OrderId);
        // ProfileResultVM PlaceOrder(Int64 userid, int pmode);

        ProfileResultVM PlaceOrder(long userid, int pmode, OrderDeliveryVM drec);

    }
}
