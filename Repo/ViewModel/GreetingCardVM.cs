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
    public class GreetingCardVM
    {


        public Int64 GreetingCardId { get; set; }
        public string CardTitle { get; set; }
        public string CardDescription { get; set; }
        public string DesignerName { get; set; }
        public bool IsDigital { get; set; }
        public Int64 SubCategoryId { get; set; }
        public Int64 CategoryID { get; set; }
        public string CategoryName { get; set; }  
        public string SubCategoryName { get; set; }
        
        public Int64 ProductId { get; set; }
        
        public decimal Price {  get; set; }
        public int ProductType { get; set; }
        public string PhotoPath { get; set; }
        [NotMapped]

        public IFormFile ActualFile { get; set; }

        public Int64 StoreId { get; set; }
    }
}
