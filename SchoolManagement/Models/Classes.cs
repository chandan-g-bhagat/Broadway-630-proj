using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Models
{
    public class Classes
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string RoomNumber { get; set; }

        public Guid? ClassTeacherId { get; set; }

        [ForeignKey("ClassTeacherId")]
        public virtual Teacher ClassTeacher { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}