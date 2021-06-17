using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.Models;

namespace SchoolManagement.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext() : base("name=Default")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
    }
}