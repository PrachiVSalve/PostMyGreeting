using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModel
{
    public class CartVM
    {
        public Int64 CartId { get; set; }
        public DateTime CartDate { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public Int64 GiftItemId { get; set; }
        public string GiftItemTitle { get; set; }
        public string PhotoPath { get; set; }
        [NotMapped]

        public IFormFile ActualFile { get; set; }
        public Int64 OfferId { get; set; }
        public Int64 StoreId { get; set; }
        public Int64 UserId { get; set; }
        public Int64 ProductId { get; set; }
        public string ProductName { get; set; }
        public Int64 GreetingCardId { get; set; }
        public string CardTitle { get; set; }
        public Int64 OrderId { get; set; }
    }
}
