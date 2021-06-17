using SchoolManagement.Data;
using SchoolManagement.Models;
using SchoolManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Services
{
    public static class ClassService
    {
        private static DefaultContext db = new DefaultContext();

        public static ResponseViewModel CreateClass(ClassCreateViewModel model)
        {
            var result = new ResponseViewModel();
            try
            {
                var classes = new Classes()
                {
                    Id = Guid.NewGuid(),
                    Name = model.Name,
                    RoomNumber = model.RoomNumber,
                    ClassTeacherId = model.Teacherid
                };

                db.Classes.Add(classes);
                db.SaveChanges();

                result.Status = true;
                result.Message = "Class created successfully";
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return result;
        }

        public static Dictionary<string, string> GetAllClassDictionary() => db.Classes.ToDictionary(p => p.Id.ToString(), p => p.Name);
    }
}