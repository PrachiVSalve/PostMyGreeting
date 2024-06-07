using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("CartTable")]
    public class Cart
    {
        [Key]
        public Int64 CartId {  get; set; }
        public DateTime CartDate { get; set; }
        public decimal Price {  get; set; }
        public int Qty { get; set; }
        [ForeignKey("Product")]
        public Int64 ProductId { get; set; }
        public virtual Product Product { get; set; }
        //[ForeignKey("Offer")]
        //public Int64 OfferId { get; set; }
        //public virtual Offer Offer { get; set; }
        [ForeignKey("User")]
        public Int64 UserId { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("Store")]
        public Int64 StoreId { get; set; }
        public virtual Store Store { get; set; }    

    }
}
