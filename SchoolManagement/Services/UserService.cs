using SchoolManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.ViewModel;

namespace SchoolManagement.Services
{
    public static class UserService
    {
        private static DefaultContext db = new DefaultContext();

        public static LoginResponseViewModel Login(LoginRequestViewModel model)
        {
            var result = new LoginResponseViewModel();
            try
            {
                var existingUser = db.Users.FirstOrDefault(p => p.UserName == model.UserName);
                if (existingUser == null)
                {
                    result.Message = "User not found";
                }
                else
                {
                    if (model.HashedPassword == existingUser.PasswordHashed)
                    {
                        result.Status = true;
                        result.Message = "Successfully logged in";
                        result.UserId = existingUser.Id;
                        result.UserName = existingUser.UserName;
                        result.Type = existingUser.UserType;
                    }
                    else
                    {
                        result.Message = "Password didnot match";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                
            }

            return result;
        }
    }
}
