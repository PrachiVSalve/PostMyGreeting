using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("Dispatch")]
    public class Dispatch
    {
        [Key]
        public Int64 DispatchId {  get; set; }
        public DateTime DispatchDate { get; set; }  
        public string DocketNo { get; set; }    
        public DateTime ExpectedRichDate { get; set; }
        [ForeignKey("Order")]
        public Int64 OrderId { get; set; }
        public virtual Order Order { get; set; }
        [ForeignKey("DispatchAgency")]
        public Int64 DispatchAgencyId { get; set; }
        public virtual DispatchAgency Agency { get; set; }
    }
}
