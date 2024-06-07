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
    public class OfferRepo : GenRepo<Offer>, IOffer
    {
        ProContext cntx;
        public OfferRepo(ProContext cntx) : base(cntx)
        {
            this.cntx = cntx;
        }
        //public List<Offer> GetAllByStoreID(long storeid)
        //{
        //    return this.cntx.Offers.Where(p => p.StoreId == storeid).ToList();
        //}
    } 
}
