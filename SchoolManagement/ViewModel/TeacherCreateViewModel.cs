using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.ViewModel
{
    public class TeacherCreateViewModel : AdminTeacherListViewModel
    {
        public string Password { get; set; }

        public string HashedPassword
        {
            get
            {
                return Common.MD5Hash.Create(Password);
            }
        }
    }

    public class AdminTeacherListViewModel
    {
        public Guid TeacherId { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }

        public string Email { get; set; }
    }

    public class TeacherCreateResponseViewModel : ResponseViewModel
    {
        public Guid StudentId { get; set; }
        public Guid TeacherUserId { get; set; }
    }
}