using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core
{
    [Table("GiftItem")]
    public  class GiftItem
    {
        [Key]
        public Int64 GiftItemId {  get; set; }
        public string GiftItemTitle {  get; set; }
        public string PhotoPath {  get; set; }
        [NotMapped]
         
        public IFormFile ActualFile { get; set; }
        public string GiftItemDescription {  get; set; }
        [ForeignKey("Product")]
        public Int64 ProductId { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("SubCategory")]
        public Int64 SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public GiftItem()
        {
            Product = new Product();
        }
    }
}
