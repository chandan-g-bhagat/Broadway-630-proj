using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.ViewModel
{
    public class ChangePasswordViewModel
    {
        public Guid Id { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }

        public string HashedNewPassword
        {
            get
            {
                return Common.MD5Hash.Create(NewPassword);
            }
        }

        public string HashedOldPassword
        {
            get
            {
                return Common.MD5Hash.Create(OldPassword);
            }
        }
    }
}