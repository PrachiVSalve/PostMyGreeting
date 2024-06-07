using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ReturnTable")]
    public class Return
    {
        [Key]
        public Int64 ReturnId {  get; set; }
        public DateTime ReturnDate { get; set; }
        public string ReturnReasion { get; set; }
        [ForeignKey("Product")]
        public Int64 ProductId { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("Order")]
        public Int64 OrderId { get; set; }
        public virtual Order Order { get; set; }   
        public virtual List<Refund> Refunds { get; set; }
    }
}
