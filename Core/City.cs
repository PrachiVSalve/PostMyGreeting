using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("CityTable")]
    public class City
    {
        [Key]
        public Int64 CityId {  get; set; }
        [Required(ErrorMessage = "City Name Required")]
        public string CityName {  get; set; }   
        public string CityDescription { get; set; }
        [ForeignKey("State")]
        public Int64 StateId { get; set; }
        public virtual State State { get; set; }
        public virtual List<Store> Stores { get; set; }
        public virtual List<OrderDelivery> DeliveryOrders { get; set;}
    }
}
