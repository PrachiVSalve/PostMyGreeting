using Core;
using Repo.ViewModel.Change_Password;
using Repo.ViewModel.Login;
using Repo.ViewModel.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IStore:IGeneric<Store>
    {
        LoginResultVM Login(LoginVM rec);
        void SignUp(StoreProVM rec);
        ProfileResultVM EditProfile(StoreProVM rec, Int64 id);
        StoreProVM GetById(Int64 id);
        ChangePasswordResultVM ChangePassword(ChangePasswordVM rec, Int64 id);
        void Logout();
        
    }
}
