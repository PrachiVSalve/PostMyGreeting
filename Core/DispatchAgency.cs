using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("DispatchAgencyTable")]
    public class DispatchAgency
    {
        [Key]
        public Int64 DispatchAgencyId {  get; set; }
        public string AgencyName { get; set; }
        public string Address {  get; set; } 
        public string Emial {  get; set; }
        public string MobileNo { get; set; }
        public string ContactPerson {  get; set; }
        public virtual List<Dispatch> Dispatches { get; set;}
    }
}
