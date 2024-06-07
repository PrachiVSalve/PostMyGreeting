using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("CountryTable")]
    public class Country
    {
        [Key]
        public Int64 CountryId {  get; set; }
        [Required(ErrorMessage = "Country Name Required")]
        public String CountryName { get; set; }   
        public string CountryDescription { get; set; }
        public virtual List<State> States { get; set; }
    }
}
