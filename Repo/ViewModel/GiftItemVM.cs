using Core;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModel
{
    public class GiftItemVM
    {
        public Int64 GiftItemId { get; set; }
        public string GiftItemTitle { get; set; }
        public string PhotoPath { get; set; }
        [NotMapped]
         
        public IFormFile ActualFile { get; set; }
         
        public string GiftItemDescription { get; set; }
        public Int64 SubCategoryId { get; set; }
        public String SubCategoryName {  get; set; }
       
        public Int64 CategoryID { get; set; }
        public Int64 ProductId { get; set; }
        public decimal Price {  get; set; }
        public int ProductType { get; set; }
        public string CategoryName {  get; set; }
        public Int64 StoreId { get; set; }
        public virtual SubCategory SubCategory { set; get; }
        public Int64 OfferId { get; set; }

    }
}
