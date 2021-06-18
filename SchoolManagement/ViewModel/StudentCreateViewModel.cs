using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.ViewModel
{
    public class StudentCreateViewModel : AdminStudentListViewModel
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

    public class AdminStudentListViewModel
    {
        public Guid StudentId { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }

        public string Email { get; set; }
    }

    public class StudentCreateResponseViewModel : ResponseViewModel
    {
        public Guid StudentId { get; set; }
        public Guid StudentUserId { get; set; }
    }

    public class AssignedStudentViewModel
    {
        public string Name { get; set; }
        public string Class { get; set; }
    }

    public class StudentsubjectViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Teacher { get; set; }
    }
}