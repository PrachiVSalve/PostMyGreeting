using Core;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class CountryRepo : GenRepo<Country>, ICountry
    {
        ProContext cntx;
        public CountryRepo(ProContext cntx) : base(cntx)
        {
            this.cntx = cntx;
        }
    }
}
