using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModel.Profile
{
    public class EditUserProfileVM
    {
        [Required(ErrorMessage = "First Name Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address Required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email Id Required")]
        [EmailAddress (ErrorMessage ="Invalid EmailId")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Mobile No Required")]
        public string MobileNo { get; set; }
         
        public string Password { get; set; }
         
        public DateTime DateOfBirth { get; set; }
         
        public int Gender { get; set; }

    }
}
