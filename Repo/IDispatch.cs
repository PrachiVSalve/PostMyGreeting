using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IDispatch:IGeneric<Dispatch>
    {
        List<Order> GetAllByOrderID(Int64 storeid);
        List<Order> GetAllByUserOrderID(Int64 userid);
    }
}
