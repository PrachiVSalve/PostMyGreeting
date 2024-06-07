using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModel
{
    public class CityVM
    {
        public Int64 CityId { get; set; }
         [Required(ErrorMessage = "City Name Required")]
        public string CityName { get; set; }
        public Int64 CountryId {  get; set; }
        public Int64 StateId {  get; set; }
        
    }
}
