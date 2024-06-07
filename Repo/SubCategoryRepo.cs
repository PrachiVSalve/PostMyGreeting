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
    public class SubCategoryRepo : GenRepo<SubCategory>, ISubCategory
    {
        ProContext cntx;
        public SubCategoryRepo(ProContext cntx) : base(cntx)
        {
            this.cntx = cntx;
        }
        public List<SubCategoryVM> GetSubCategoryByCategoryId(long categoryid)
        {
            var v = from t in this.cntx.SubCategories
                    where t.CategoryID == categoryid
                    select new SubCategoryVM
                    {
                       SubCategoryId=t.SubCategoryId,
                       SubCategoryName=t.SubCategoryName,
                    };

            return v.ToList();
        }

        
    }
}
