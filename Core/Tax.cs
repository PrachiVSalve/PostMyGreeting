using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TaxTable")]
    public class Tax
    {
        [Key ]
        public Int64 TaxId { get; set; }
        public decimal CGSTRate { get; set; }   
        public decimal SGSTRate { get; set; }
        public decimal IGSTRate { get; set; }
        public string HSNSACNo {  get; set; }
    }
}
