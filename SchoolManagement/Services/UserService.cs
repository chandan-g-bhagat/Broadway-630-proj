﻿using SchoolManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.ViewModel;
using SchoolManagement.Models;

namespace SchoolManagement.Services
{
    public static class UserService
    {
        private static DefaultContext db = new DefaultContext();

        public static LoginResponseViewModel Login(LoginRequestViewModel model)
        {
            var result = new LoginResponseViewModel();
            try
            {
                var existingUser = db.Users.FirstOrDefault(p => p.UserName == model.UserName);
                if (existingUser == null)
                {
                    result.Message = "User not found";
                }
                else
                {
                    if (model.HashedPassword == existingUser.PasswordHashed)
                    {
                        result.Status = true;
                        result.Message = "Successfully logged in";
                        result.UserId = existingUser.Id;
                        result.UserName = existingUser.UserName;
                        result.Type = existingUser.UserType;
                    }
                    else
                    {
                        result.Message = "Password didnot match";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                
            }

            return result;
        }

        /// <summary>
        /// Creates the student and its respective user
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static StudentCreateResponseViewModel CreateStudentUser(StudentCreateViewModel model)
        {
            var result = new StudentCreateResponseViewModel();
            try
            {
                //splitting the incoming model into 2 models that reflects the database table
                var user = new User() {
                    Id = Guid.NewGuid(),
                    IsActive = true,
                    PasswordHashed = model.HashedPassword,
                    UserName = model.Username,
                    UserType = Common.UserType.Student
                };
                db.Users.Add(user);

                var student = new Student() {
                    Id = Guid.NewGuid(),
                    Address = model.Address,
                    Email = model.Email,
                    Name = model.Name,
                    UserId = user.Id
                };
                db.Students.Add(student);

                db.SaveChanges();

                result.Status = true;
                result.Message = "Student added successfully";
                result.StudentUserId = user.Id;
                result.StudentId = student.Id;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }

            return result;
        }

        public static IEnumerable<AdminStudentListViewModel> GetAllStudents()
        {
            var data = db.Students.Select(p => new AdminStudentListViewModel
            {
                StudentId = p.Id,
                Address = p.Address,
                Email = p.Email,
                Name = p.Name,
                Username = p.StudentUser.UserName

            }) ;

            return data.AsEnumerable();
        }
    }
}
