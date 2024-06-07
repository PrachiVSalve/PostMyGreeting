using Core;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repo.ViewModel.Profile;
using Repo.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class StateRepo : GenRepo<State>, IState
    {
        ProContext cntx;
        public StateRepo( ProContext cntx) : base(cntx)
        {
            this.cntx = cntx;
        }

        public List<StateVM> GetStateByCountryId(long countryid)
        {
            var v = from t in this.cntx.States
                    where t.CountryId == countryid
                    select new StateVM
                    {
                        StateId=t.StateId,
                        StateName=t.StateName,
                    };

            return v.ToList();
        }
    }
}
