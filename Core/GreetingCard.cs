using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Core
{
    [Table("GreetingCardTable ")]
    public  class GreetingCard
    {
        [Key]
        public Int64 GreetingCardId { get; set; }  
        public string CardTitle {  get; set; }
        public string CardDescription { get; set; }
        public string DesignerName {  get; set; }
        public bool IsDigital {  get; set; }
        public string PhotoPath { get; set; }
        [NotMapped]
        public IFormFile ActualFile { get; set; }
        [ForeignKey("SubCategory")]
        public Int64 SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        [ForeignKey("Product")]
        public Int64 ProductId { get; set; }
        public virtual Product Product { get; set; }

        public GreetingCard()
        {
            Product = new Product();
        }
    }
}
