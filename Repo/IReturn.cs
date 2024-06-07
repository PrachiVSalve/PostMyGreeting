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
    public interface IReturn: IGeneric<Return>
    {
        ReturnVM ReturnDet(Int64 returnid);
        ProfileResultVM AddReturns(ReturnVM rec);
        ReturnVM GetRefundDetails(long returnid);
    }
}
