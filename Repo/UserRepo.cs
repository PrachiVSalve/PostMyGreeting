using Core;
using Entities;
using Repo.ViewModel.Change_Password;
using Repo.ViewModel.Login;
using Repo.ViewModel.Profile;

namespace Repo
{
    public class UserRepo : IUser
        
    {
        ProContext cntx;
        public UserRepo(ProContext cntx)
        {
            this.cntx = cntx;
        }

        public ChangePasswordResultVM ChangePassword(ChangePasswordVM rec, long id)
        {
         ChangePasswordResultVM res = new ChangePasswordResultVM();
            //find old record
            var oldrec = this.cntx.Users.Find(id);
            if (oldrec.Password == rec.OldPassword)
            {
                oldrec.Password = rec.NewPassword;
                this.cntx.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Password Changed Successfully!";
            }
            else
            {
                res.IsSuccess = false;
                res.Message = "Invalid Old Password!";
            }

            return res;
        }

        public ProfileResultVM EditProfile(EditUserProfileVM rec, long id)
        {
            ProfileResultVM res = new ProfileResultVM();
            try
            {
                var oldrec = this.cntx.Users.Find(id);
                oldrec.FirstName= rec.FirstName;
                oldrec.LastName= rec.LastName;
                oldrec.Address = rec.Address;
                oldrec.Email = rec.EmailId;
                oldrec.MobileNo = rec.MobileNo;
                 
                
                this.cntx.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Profile Updated Successfully!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message.ToString();
            }

            return res;
        }

        public EditUserProfileVM GetById(long id)
        {
            var rec = (from t in this.cntx.Users
                       where t.UserId == id
                       select new EditUserProfileVM
                       {
                           FirstName = t.FirstName,
                           LastName = t.LastName,
                           Address = t.Address,
                           EmailId = t.Email,
                           MobileNo = t.MobileNo,
                            
                       }).FirstOrDefault();
            return rec;
        }

        public LoginResultVM Login(LoginVM rec)
        {
            LoginResultVM res = new LoginResultVM();
            var urec= this.cntx.Users.SingleOrDefault(p=>p.Email==rec.EmailId && p.Password==rec.Password);
            if(urec!=null)
            {
                res.IsSuccess = true;
                res.LoggedInId=urec.UserId;
                res.LoggedInName=urec.FullName;
            }
            else
            {
                res.IsSuccess = false;
                res.ErrorMessage="Invalid EmailId or Password";
            }
            return res;
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
        public void SignUp(UserProfileVM rec)
        {
            User urec = new User();
            urec.FirstName = rec.FirstName;
            urec.LastName = rec.LastName;
            urec.Address = rec.Address;
            urec.Email = rec.EmailId;
            urec.MobileNo = rec.MobileNo;
            urec.Password = rec.Password;
            urec.DateOfBirth = rec.DateOfBirth;
            urec.Gender = rec.Gender;           
            this.cntx.Users.Add(urec);
            this.cntx.SaveChanges();
        }
    }
}
