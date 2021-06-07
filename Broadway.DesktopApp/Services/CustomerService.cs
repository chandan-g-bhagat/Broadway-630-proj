using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.DesktopApp.Services
{
    public class CustomerService
    {
        private CodeFirst.CodeFirstContext db = new CodeFirst.CodeFirstContext();

        public List<Model.CustomerDetails> GetAll()
        {
            return db.Customer.ToList();
        }

        public Model.CustomerDetails GetById(int id)
        {
            return db.Customer.Find(id);
        }

     }
}
