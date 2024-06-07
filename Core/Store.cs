using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("StoreTable")]
    public class Store
    {
        [Key]
        public Int64 StoreId {  get; set; }
        [Required(ErrorMessage = "Store Name Required")]
        public string StoreName { get; set; }
        [Required(ErrorMessage = "Address Required")]
        public string Address {  get; set; }
        [Required(ErrorMessage = "ContactNo Required")]
        public string ContactNo { get; set; }
        [Required(ErrorMessage = "Email Address Required")]
        [DataType(DataType.Password)]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "MobileNo Required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Input 10 digits")]
        public string Password { get; set; }
        [Required(ErrorMessage = "ContactPersonName Required")]
        public string ContactPersonName { get; set; }
        public bool IsActive { get; set; }
         
        
        [ForeignKey("City")]
        public Int64 CityId { get; set; }
        public virtual City City { get; set; }
        public virtual List<Product> Products { get; set; } 
        public virtual List<Cart> Carts { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<StoreReview> StoreReviews { get; set; }
        //public virtual List<Offer> Offers { get; set; }
         
         
    }
}
