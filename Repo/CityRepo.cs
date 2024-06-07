using Core;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class CityRepo : GenRepo<City>, ICity
    {
        ProContext cntx;
        public CityRepo(ProContext cntx) : base(cntx)
        {
            this.cntx = cntx;
        }

        public List<CityVM> GetCityByStateId(long stateid)
        {

            var v = from t in this.cntx.Cities
                    where t.StateId == stateid
                    select new CityVM
                    {
                       CityId = t.CityId,
                       CityName = t.CityName,

                       
                    };

            return v.ToList();
        }
    }
}
