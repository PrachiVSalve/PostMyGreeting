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
    public interface IUser
    {
        LoginResultVM Login(LoginVM rec);
        ProfileResultVM EditProfile(EditUserProfileVM rec, Int64 id);
        EditUserProfileVM GetById(Int64 id);
        ChangePasswordResultVM ChangePassword(ChangePasswordVM rec, Int64 id);
        void Logout();
        void SignUp(UserProfileVM rec);
    }
}
