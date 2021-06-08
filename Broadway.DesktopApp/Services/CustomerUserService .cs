using Broadway.DesktopApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.DesktopApp.Services
{
    public class CustomerUserService
    {
        private CodeFirst.CodeFirstContext db = new CodeFirst.CodeFirstContext();

        public bool Insert(CustomerUserModel model)
        {
            try
            {
                SqlParameter
                    [] parameters = new SqlParameter[6];
                parameters[0] = new SqlParameter("@Name", model.Name);
                parameters[1] = new SqlParameter("@Address", model.Address);
                parameters[2] = new SqlParameter("@Phone", model.Phone);
                parameters[3] = new SqlParameter("@UserName", model.UserName);
                parameters[4] = new SqlParameter("@Password", model.Password);
                parameters[5] = new SqlParameter("@Email", model.Email);

                db.Database.ExecuteSqlCommand("exec SP_CustomerUser @Name, @Address, @Phone, @UserName, @Password, @Email",parameters );
                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<CustomerDetails> GetAllCustomers()
        {
            return db.Customer.ToList();
        }

        public List<UserDetails> GetAllUsers()
        {
            return db.Users.ToList();
        }


        public List<CustomerUserModel> GetAllCustomerUser()
        {
            var data = db.Customer.Select(p => new CustomerUserModel {
                Address = p.CustomerAddress,
                Name = p.CustomerName,
                Phone = p.Phone,
                Email = p.User == null ? "" : p.User.Email,
                Password = p.User == null ? "" : p.User.Password,
                UserName = p.User == null ? "" : p.User.UserName
            }).ToList();
            return data;
        }
    }
}
