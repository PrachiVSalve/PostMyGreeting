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
    public interface IAdmin
    {
        LoginResultVM Login(LoginVM rec);
        ProfileResultVM EditProfile(ProfileVM rec, Int64 id);
        ProfileVM GetById(Int64 id);
        ChangePasswordResultVM ChangePassword(ChangePasswordVM rec, Int64 id);
        void Logout();
    }
}
