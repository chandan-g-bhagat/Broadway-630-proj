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
    public static class SubjectService
    {
        private static DefaultContext db = new DefaultContext();

        public static ResponseViewModel CreateSubjects(SubjectCreateViewModel model)
        {
            var result = new ResponseViewModel();
            try
            {
                var subject = new Subject()
                {
                    Id = Guid.NewGuid(),
                    Name = model.Name,
                    Code = model.Code,
                    ClassId = model.ClassId,
                    TeacherId = model.TeacherId
                };
                db.Subjects.Add(subject);
                db.SaveChanges();

                result.Status = true;
                result.Message = "Subject Added Successfully";
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }

            return result;
        }

        public static List<SubjectListViewModel> GetAllSubjects()
        {
            return db.Subjects.Select(p => new SubjectListViewModel
            {
                SubjectId = p.Id,
                Class = p.Class.Name,
                Teacher = p.Teacher.Name,
                Name = p.Name,
                Code = p.Code
            }).ToList();
        }
    }
}