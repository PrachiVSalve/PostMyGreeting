using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModel.Profile
{
    public class StoreProVM
    {
        public Int64 StoreId { get; set; }
        [Required(ErrorMessage = "Store Name Required")]
        public string StoreName { get; set; }
        [Required(ErrorMessage = "Address Required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "ContactNo Required")]
        
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Input 10 digits")]
        public string ContactNo { get; set; }
        [Required(ErrorMessage = "Email Address Required")]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "ContactPersonName Required")]
        public string ContactPersonName { get; set; }
        //public bool IsActive { get
        //    {
        //        return true;
        //    }
        //}

       
        public Int64 CountryId { get; set; }
        public Int64 StateId { get; set; }
        public Int64 CityId { get; set; }
    }
}
