using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("OrderDeliveryTable")]
    public class OrderDelivery
    {
        [Key]
        public Int64 OrderDeliveryId {  get; set; } 
        public string DeliverToPersonName {  get; set; }    
        public  string DeliveryAddress { get; set; }
        public string PinCode {  get; set; }
        public string ContactNo {  get; set; }

        [ForeignKey("Order")]
        public Int64 OrderId { get; set; }
        public virtual Order Order { get; set; }
        [ForeignKey("City")]
        public Int64 CityId { get; set; }
        public virtual City City { get; set; }  

    }
}
