using Entities;
using Repo.ViewModel.Change_Password;
using Repo.ViewModel.Login;
using Repo.ViewModel.Profile;

namespace Repo
{
    public class AdminRepo : IAdmin
    {
        ProContext cntx;
        public AdminRepo(ProContext cntx)
        {
            this.cntx = cntx;
        }

        public ChangePasswordResultVM ChangePassword(ChangePasswordVM rec, long id)
        {
         ChangePasswordResultVM res = new ChangePasswordResultVM();
            //find old record
            var oldrec = this.cntx.Admins.Find(id);
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

        public ProfileResultVM EditProfile(ProfileVM rec, long id)
        {
            ProfileResultVM res = new ProfileResultVM();
            try
            {
                var oldrec = this.cntx.Admins.Find(id);
                oldrec.FirstName= rec.FirstName;
                oldrec.LastName= rec.LastName;
                oldrec.Address = rec.Address;
                oldrec.EmailId = rec.EmailId;
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

        public ProfileVM GetById(long id)
        {
            var rec = (from t in this.cntx.Admins
                       where t.AdminId == id
                       select new ProfileVM
                       {
                           FirstName = t.FirstName,
                           LastName = t.LastName,
                           Address = t.Address,
                           EmailId = t.EmailId,
                           MobileNo = t.MobileNo,
                           Password = t.Password,
                       }).FirstOrDefault();
            return rec;
        }

        public LoginResultVM Login(LoginVM rec)
        {
            LoginResultVM res = new LoginResultVM();
            var urec= this.cntx.Admins.SingleOrDefault(p=>p.EmailId==rec.EmailId && p.Password==rec.Password);
            if(urec!=null)
            {
                res.IsSuccess = true;
                res.LoggedInId=urec.AdminId;
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
    }
}
