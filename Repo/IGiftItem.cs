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
    public interface IGiftItem:IGeneric<GiftItem>
    {
        //ProfileResultVM AddToGiftItem(GiftItemVM rec, int productmode);
        //List<GiftItem> GetAllByStoreID(Int64 storeid);
        void Add(GiftItemVM rec);
        void Edit(GiftItemVM rec);
        //void DeleteGP(GiftItemVM rec);
        public void DeleteGP(GiftItemVM rec);
        GiftItemVM GetByGIftId(long id);
        List<GiftItem> SearchByProductType(Int64 protype=0,Int64 subcat=0);
        List<GiftItem> GetAllByStoreID(Int64 storeid);
    }
}
