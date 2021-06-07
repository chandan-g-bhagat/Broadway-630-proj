using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.DesktopApp.CodeFirst
{
    public class CodeFirstContext : DbContext
    {
        public CodeFirstContext() : base("name=CodeFirstConnection")
        {

        }

        public virtual DbSet<Model.CustomerDetails> Customer { get; set; }
        public virtual DbSet<Model.UserDetails> Users { get; set; }
    }
}
