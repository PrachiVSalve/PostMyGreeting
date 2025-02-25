﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core
{
    [Table("AdminTable")]
    public class Admin
    {
        [Key]
        public Int64 AdminId {  get; set; }
        [Required(ErrorMessage ="First Name Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name Required")]
        public string LastName { get; set; }
       
        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName +" " + LastName;
            }
        }
        [Required(ErrorMessage = "EmailId Required")]
        [EmailAddress(ErrorMessage = "Invalid EmailId")]
        public string EmailId {  get; set; }
        [Required(ErrorMessage = "MobileNo Required")]
        [RegularExpression(@"^\d{10}$",ErrorMessage ="Input 10 digits")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Address Required")]
        public string Address {  get; set; }

    }
}
