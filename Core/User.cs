using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("UserTable")]
    public class User
    {
        [Key]
        public Int64 UserId { get; set; }
        //[Required(ErrorMessage = "First Name Required")]
        public string FirstName {  get; set; }
        //[Required(ErrorMessage = "Last Name Required")]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        //[Required(ErrorMessage = "Email Id Required")]
        //[EmailAddress (ErrorMessage ="Invalid EmailId")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Password Required")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }
        //[Required(ErrorMessage = "MobileNo Required")]
        //[RegularExpression(@"^\d{10}$", ErrorMessage = "Input 10 digits")]
        public string MobileNo { get; set; }
        //[Required(ErrorMessage = "Address Required")]
        public string  Address{ get; set; }
        //[Required(ErrorMessage = "Date Of Birth Required")]
        public DateTime DateOfBirth { get; set; }
        //[Required(ErrorMessage = "Gender Required")]
        public int Gender {  get; set; }

        public bool IsActive {get;set; }
             
        public virtual List<Cart> Carts { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<StoreReview> StoreReviews { get; set; }

    }
}
