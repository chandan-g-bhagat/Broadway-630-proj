using SchoolManagement.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    [Table("User_Info")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHashed { get; set; }
        public bool IsActive { get; set; }
        public UserType UserType { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}
