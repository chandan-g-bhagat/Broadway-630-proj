using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.ViewModel
{
    public class LoginRequestViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public string HashedPassword
        {
            get
            {
                return Common.MD5Hash.Create(Password);
            }
        }
    }

    public class LoginResponseViewModel : ResponseViewModel
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public Common.UserType Type { get; set; }
    }

    public class ResponseViewModel
    {
        public bool Status { get; set; } = false;
        public string Message { get; set; }
    }
}