using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("OrderDetails")]
    public class OrderDetails
    {
        [Key]
        public Int64 OrderDetailsId {  get; set; }
        public int Qty { get; set; }    
        public decimal Price {  get; set; }
        [ForeignKey("Order")]
        public Int64 OrderId { get; set; }
        public virtual Order Order { get; set; }
        [ForeignKey("Product")]
        public Int64 ProductId { get; set; }
        public virtual Product Product { get; set; }    

    }
}
