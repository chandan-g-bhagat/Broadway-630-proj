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
    public static class StudentService
    {
        public static DefaultContext db = new DefaultContext();

        public static Dictionary<string, string> GetAllUnAssignedStudents()
        {
            return db.Students.Where(p => !p.ClassId.HasValue).ToDictionary(p => p.Id.ToString(), p => p.Name);
        }

        public static ResponseViewModel AssignStudent(Guid StudentId, Guid ClassId)
        {
            var result = new ResponseViewModel();
            try
            {
                var student = db.Students.Find(StudentId);
                if (student != null)
                {
                    student.ClassId = ClassId;
                    db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    result.Status = true;
                    result.Message = "Assigned";
                }
                else
                {
                    result.Message = "Student not found";
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return result;
        }

        public static List<AssignedStudentViewModel> GetListofAssignedStudents()
        {
            return db.Students.Where(p => p.ClassId.HasValue).Select(p => new AssignedStudentViewModel { Name = p.Name, Class = p.Classes.Name }).ToList();
        }

        public static List<Student> GetStudentsByClassId(Guid classId) => db.Students.Where(p => p.ClassId.HasValue && p.ClassId.Value == classId).ToList();
    }
}