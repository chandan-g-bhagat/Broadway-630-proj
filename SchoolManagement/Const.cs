using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Const
    {
        public class Appsettings
        {
            public const string AppName = "AppNames";
        }
        public class Basic
        {
            public const string Login = "Login to {0}";
            public const string FailedLogin = "Login Failed! Please try once more";
            public const string ErrorOccured = "Some Error Occured";
            public const string WrongPasswordPrompt = "Password and confirm password does not match!";

        }

        public class Admin
        {
            public const string Attendance = "Attendance";
        }
    }
}
