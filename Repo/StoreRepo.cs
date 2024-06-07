using Core;
using Entities;
using Repo.ViewModel.Change_Password;
using Repo.ViewModel.Login;
using Repo.ViewModel.Profile;

namespace Repo
{
    public class StoreRepo :GenRepo<Store>, IStore
    {
        ProContext cntx;
        public StoreRepo(ProContext cntx):base(cntx)
        {
            this.cntx = cntx;
        }

        public ChangePasswordResultVM ChangePassword(ChangePasswordVM rec, long id)
        {
         ChangePasswordResultVM res = new ChangePasswordResultVM();
            //find old record
            var oldrec = this.cntx.Stores.Find(id);
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

        public ProfileResultVM EditProfile(StoreProVM rec, long id)
        {
            ProfileResultVM res = new ProfileResultVM();
            try
            {
                var oldrec = this.cntx.Stores.Find(id);
                oldrec.StoreName = rec.StoreName;
                oldrec.Address = rec.Address; 
                oldrec .EmailAddress = rec.EmailAddress;
                oldrec.ContactNo = rec.ContactNo;
                oldrec.ContactPersonName = rec.ContactPersonName;
                //oldrec.IsActive = rec.IsActive; 
                oldrec.CityId= rec.CityId;  
                
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

        public StoreProVM GetById(long id)
        {
            var rec = (from t in this.cntx.Stores
                       where t.StoreId == id
                       select new StoreProVM
                       {
                            CityId = t.CityId,
                            StoreName = t.StoreName,
                            Address = t.Address,
                            EmailAddress = t.EmailAddress,
                            ContactNo = t.ContactNo,
                            ContactPersonName = t.ContactPersonName,

                       }).FirstOrDefault();
            return rec;
        }

        public LoginResultVM Login(LoginVM rec)
        {
            LoginResultVM res = new LoginResultVM();
            var urec= this.cntx.Stores.SingleOrDefault(p=>p.EmailAddress==rec.EmailId && p.Password==rec.Password);
            if(urec!=null)
            {
                res.IsSuccess = true;
                res.LoggedInId=urec.StoreId;
                res.LoggedInName=urec.StoreName;
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

        public void SignUp(StoreProVM rec)
        {
            Store urec = new Store();
            urec.StoreName = rec.StoreName;
            urec.EmailAddress = rec.EmailAddress;
            urec.Password = rec.Password;
            urec.ContactPersonName = rec.ContactPersonName;
            urec.ContactNo = rec.ContactNo;
            urec.Address = rec.Address;
            urec.CityId = rec.CityId;
            
            
            this.cntx.Stores.Add(urec);
            this.cntx.SaveChanges();
        }
    }
}
