using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("RefundTable")]
    public class Refund
    {
        [Key]
        public Int64 RefundId { get; set; }
        public DateTime RefundDate { get; set; }
        public decimal RefundAmount { get; set; }
        [ForeignKey("Return")]
        public Int64 ReturnId { get; set; }
        public virtual Return Return {  get; set; }  
    }
}
