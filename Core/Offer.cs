using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("OfferTable")]
     public class Offer
    {
        [Key]
        public Int64 OfferId {  get; set; } 
        public string OfferTitle {  get; set; }
        public decimal Discount {  get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        //[ForeignKey("Store")]
        //public Int64 StoreId { get; set; }
        //public virtual Store Store { get; set; }
        //public virtual List <Cart> Carts { get; set; }
        //public virtual List<Order> Orders { get; set; }


    }
}
