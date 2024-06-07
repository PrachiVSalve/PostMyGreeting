using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModel
{
    public class ReturnVM
    {
        public Int64 ReturnId { get; set; }
        public DateTime ReturnDate { get; set; }
        public string ReturnReasion { get; set; }
        
        public Int64 ProductId { get; set; }
        public decimal Price { get; set; }
        public int ProductType { get; set; }
        public Int64 OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Int64 UserId { get; set; }
        public Int64 StoreId { get; set; }
        public Int64 RefundId { get; set; }
        public DateTime RefundDate { get; set; }
        public decimal RefundAmount { get; set; }
        public Int64 GiftItemId { get; set; }
        public string GiftItemTitle { get; set; }
        public Int64 GreetingCardId { get; set; }
        public string CardTitle { get; set; }

    }
}
