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
    public interface IGreetingCard:IGeneric<GreetingCard>
    {

        void Add(GreetingCardVM rec);
        void Edit(GreetingCardVM rec);
        void DeleteGP(GreetingCardVM rec);
        GreetingCardVM GetByGreetingId(long id);
        List<GreetingCard> SearchByProductType(Int64 protype = 0, Int64 subcat = 0);
        List<GreetingCard> GetAllByStoreID(Int64 storeid);
    }
}
