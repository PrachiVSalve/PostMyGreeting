using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("PaymentTable")]
    public class Payment
    {
        [Key]
        public Int64 PaymentId {  get; set; }
        public DateTime PaymentDate {  get; set; }
        public  decimal Amount {  get; set; }
        public decimal  DiscountAmount{ get; set; }
        public int PaymentMode {  get; set; }//PaymentModeEnum
        [ForeignKey("Order")]
        public Int64 OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
