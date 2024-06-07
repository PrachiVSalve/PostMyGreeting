using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("StoreReviewTale")]
     public class StoreReview
    {
        [Key]
        public Int64 StoreReviewId {  get; set; }
        public string Review {  get; set; }
        public DateTime ReviewDate {  get; set; }
        public int Rating {  get; set; }//Enum1-best,2-good....
        [ForeignKey("Store")]
        public Int64 StoreId { get; set; }
        public virtual Store Store { get; set; }
        [ForeignKey("User")]
        public Int64 UserId { get; set; }
        public virtual User User { get; set; }

    }
}
