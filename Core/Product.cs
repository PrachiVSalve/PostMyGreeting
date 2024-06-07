using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProductTable")]
    public class Product
    {
        [Key]
        public Int64 ProductId {  get; set; }
        public decimal Price {  get; set; }
        public int ProductType { get; set; }
        [ForeignKey("Store")]
        public Int64 StoreId { get; set; }
        public virtual Store Store { get; set; }
        public virtual List<GreetingCard> GreetingCards { get; set;}
        public virtual List<GiftItem> GiftItems { get; set; }
        public virtual List <Cart> Carts { get; set; }

        public virtual List<Complaint> Complaints { get; set; }
        public virtual List <OrderDetails> OrderDetails { get; set; }
        public Product()
        {
            GiftItems = new List<GiftItem>();
            GreetingCards = new List<GreetingCard>();
        }
    }
}
