using Core;
using Repo.ViewModel.Profile;
using Repo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IState:IGeneric<State>
    {
        List<StateVM> GetStateByCountryId(Int64 countryid);
    }
}
