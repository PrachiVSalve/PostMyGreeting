using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModel.Login
{
    public  class LoginVM
    {
        [Required(ErrorMessage ="EmailId Required")]
        [EmailAddress(ErrorMessage ="Invalid EmailId")]
        public string EmailId {  get; set; }
        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password,ErrorMessage = "Invalid Password")]
        public string Password { get; set; }
    }
}
