using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModel.Login
{
    public class LoginResultVM
    {
        public bool IsSuccess {  get; set; }
        public string ErrorMessage { get; set; }
        public Int64 LoggedInId {  get; set; }
        public string LoggedInName { get; set; }
    }
}
