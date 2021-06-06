using Broadway.DesktopApp.DbFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.DesktopApp.Services
{
    public class StudentService
    {
        private BwEntities db = new BwEntities();

        public List<DbFirst.Student> GetAll()
        {
            return db.Students.ToList();
        }
        public DbFirst.Student GetbyId (int id)
        {
            return db.Students.Find(id);
        }

        public bool Create(DbFirst.Student model)
        {
            try
            {
                db.Students.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(DbFirst.Student model)
        {
            try
            {
                var existing = db.Students.Find(model.Id);
                if (existing==null)
                {
                    return false;
                }
                existing.Student1 = model.Student1;
                existing.Email = model.Email;
                existing.DOB = model.DOB;

                db.Entry(existing).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var existing = db.Students.Find(id);
                if (existing == null)
                {
                    return false;
                }
                db.Students.Remove(existing);
              
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
