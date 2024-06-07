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
   public interface IReview:IGeneric<StoreReview>
    {
        List<StoreReviewVM> GetByStoreId(long userid);
        ProfileResultVM AddStoreReview(StoreReviewVM rec);
        List<StoreReview> GetByAllStoresId(long userid );
    }
}
