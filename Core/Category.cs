using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("CategoryTable")]
    public class Category
    {
        [Key]
        public Int64 CategoryID {  get; set; }
        public string CategoryName { get; set; }
        public virtual List<SubCategory> SubCategories { get; set; }
    }
}
