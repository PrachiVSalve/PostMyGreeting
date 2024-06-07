using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModel
{
    public class StateVM
    {
        public Int64 StateId { get; set; }
        [Required(ErrorMessage = "State Name Required")]
        public string StateName { get; set; }
    }
}
