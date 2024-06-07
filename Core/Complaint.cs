using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ComplaintTable")]
    public class Complaint
    {
        [Key]
        public Int64 ComplaintId {  get; set; } 
        public DateTime CompliantDate { get; set; }  
        public string  CompliantResion { get; set; }
        [ForeignKey("Product")]
        public Int64 ProductId { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("Order")]
        public Int64 OrderId { get; set; }
        public virtual Order Order { get; set; }  
        public virtual List<Solution> Solutions { get; set; }


        //public Complaint()
        //{
        //    Product = new Product();
        //}

    }
}
