using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("SubCategoryTable")]
    public class SubCategory
    {
        [Key]
        public Int64 SubCategoryId {  get; set; }
        public string SubCategoryName {  get; set; }
        [ForeignKey("Category")]
        public Int64 CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<GreetingCard> GreetingCards { get; set;}
        public virtual List <GiftItem> GiftItems { get; set; }
    }
}
