using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModel
{
    public class StoreReviewVM
    {
        public Int64 StoreReviewId { get; set; }
        public string Review { get; set; }
        public DateTime ReviewDate { get; set; }
        public int Rating { get; set; } 
        public Int64 StoreId { get; set; }
        public Int64 UserId { get; set; }
        public Int64 ProductId { get; set; }
        public decimal Price { get; set; }
        public int ProductType { get; set; }
        public string StoreName { get; set; }
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
