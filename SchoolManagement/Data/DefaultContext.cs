using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;
using SchoolManagement.Models;

namespace SchoolManagement.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext() : base("name=Default")
        {

        }

        public virtual DbSet<User> Users { get; set; }
    }
}
