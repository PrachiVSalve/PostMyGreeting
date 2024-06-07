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
    public class CategoryRepo : GenRepo<Category>, ICategory
    {
        ProContext cntx;
        public CategoryRepo(ProContext cntx) : base(cntx)
        {
            this.cntx = cntx;
        }
    }
}
