using Core;
using Repo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface ICity:IGeneric<City>
    {
        List<CityVM> GetCityByStateId(Int64 stateid);
    }
}
