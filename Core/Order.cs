using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("OrderTable")]
    public class Order
    {
        [Key ]
        public Int64 OrderId {  get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsPaid {  get; set; }


        //[ForeignKey("Offer")]
        //public Int64 OfferId { get; set; }
        //public virtual Offer Offer { get; set; }

        [ForeignKey("User")]
        public Int64 UserId { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("Store")]
        public Int64 StoreId { get; set; }
        public virtual Store Store { get; set; }
        public virtual List<Payment> Payment { get; set; }
        public virtual List<Dispatch> Dispatch { get; set; }
         public virtual List<Complaint> Complaints { get; set; }
        public virtual List<OrderDelivery> DeliveryOrders { get; set; }  
        public virtual List<OrderDetails> OrderDetails { get; set; }
        public Order()
        {
            OrderDetails = new List<OrderDetails>();
            Payment = new List<Payment>();
            DeliveryOrders = new List<OrderDelivery>();
        }
    }
}
