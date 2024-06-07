using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("State")]
    public class State
    {
        [Key]
        public Int64 StateId {  get; set; }
        [Required(ErrorMessage = "State Name Required")]
        public string StateName { get; set; }   
        public string StatDescription {  get; set; }
        [ForeignKey("Country")]
        public Int64 CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual List<City> Citys { get; set; }

    }
}
