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
    public static class TeacherService
    {
        private static DefaultContext db = new DefaultContext();

        public static Dictionary<string, string> GetAllUnAssignedTeachers()
        {
            var dict = new Dictionary<string, string>();

            var allteachers = db.Teachers.ToList();

            var assignedTeacher = db.Classes.Where(p => p.ClassTeacherId.HasValue).Select(p => p.ClassTeacherId).ToList();

            List<Teacher> unassignedTeacher = new List<Teacher>();
            foreach (var item in allteachers)
            {
                if (!assignedTeacher.Contains(item.Id))
                {
                    dict.Add(item.Id.ToString(), item.Name);
                }
            }

            return dict;
        }

        public static Dictionary<string, string> GetAllTeachersDictionary()
        {
            var data = db.Teachers.ToDictionary(p => p.Id.ToString(), p => p.Name);
            return data;
        }
    }
}