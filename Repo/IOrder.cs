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
    public interface IOrder:IGeneric<Order>
    {
        List<Order> GetAllByUserID(Int64 userid);
        List<OrderDetails> GetOrderDetByUserID(Int64 userid);
        List<Order> GetAllByStoreID(Int64 storeid);
        List<CartVM> GetAllByOrderId(Int64 OrderId);
        List<CartVM> GetGreetingByOrderId(Int64 OrderId);
        List<Complaint> GetAllNewComplaints(Int64 storeid);
        List<Complaint> GetAllSolvedComplaints(Int64 storeid);
        ProfileResultVM AddComplaintSolution(Solution rec);
        Solution GetSolutionByComplaintID(Int64 ComplaintId);
        List<Return> GetReturn(Int64 storeid);
        //List<ReturnVM> GetRefund(Int64 storeid);
        List<ReturnVM> GetAllByRefund(long storeid);
        ProfileResultVM AddRefund(Refund rec);
        List<Order> GetAllOrderByUserID(Int64 userid);
        ProfileResultVM RaiseComplaint(Complaint rec);
        ProfileResultVM RetunRequst(Return rec);
        List<Complaint> GetAllUserSolvedComplaints(Int64 userid);
        List<Payment> GetCollections(string r, string p, Int64 storeid);
        List<Order> GetPendings(string r, string p, Int64 storeid);
        List<ReturnVM> GetRefunds(string r, string p, Int64 storeid);


    }
}
