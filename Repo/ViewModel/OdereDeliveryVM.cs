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
    public class OrderDeliveryVM
    {
        public Int64 OrderDeliveryId { get; set; }
        public string DeliverToPersonName { get; set; }
        public string DeliveryAddress { get; set; }
        public string PinCode { get; set; }
        public string ContactNo { get; set; }
 
        public Int64 OrderId { get; set; }
        
        public Int64 CityId { get; set; }
        public string CityName { get; set; }
        public Int64 StateId { get; set; }
        public string StateName { get; set; }
        public Int64 CountryId { get; set; }

        public String CountryName { get; set; }
        public Int64 StoreId { get; set; }
        public Int64 UserId { get; set; }
        public string Msg { get; set; } 

    }
  
}
