using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModel
{
    public class PaymentGatewayVM
    {
        public string CardNo { set; get; }
        public string ExpiryDate { set; get; }
        public string CCV { set; get; }
    }
}
