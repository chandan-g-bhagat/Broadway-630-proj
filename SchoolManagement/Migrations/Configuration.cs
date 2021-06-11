namespace SchoolManagement.Migrations
{
    using SchoolManagement.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SchoolManagement.Data.DefaultContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchoolManagement.Data.DefaultContext db)
        {
            #region Admin Seed
            var adminid = Guid.Parse("62c3140d-5464-43e4-96bd-245c89459e62");
            var hased = Common.MD5Hash.Create("Admin@123");

            var admin = new User() {
                Id = adminid,
                IsActive = true,
                PasswordHashed = hased,
                UserName = "admin",
                UserType = Common.UserType.Admin
            };
            var existing = db.Users.Find(admin.Id);
            if (existing==null)
            {
                db.Users.Add(admin);
                db.SaveChanges();
            }
            #endregion

            #region Student Seed
            var studentid = Guid.Parse("62c3140d-5464-43e4-96bd-245c89459e61");
            var sthased = Common.MD5Hash.Create("Student@123");

            var student = new User()
            {
                Id = studentid,
                IsActive = true,
                PasswordHashed = sthased,
                UserName = "student",
                UserType = Common.UserType.Student
            };
            var existingstudent = db.Users.Find(student.Id);
            if (existingstudent == null)
            {
                db.Users.Add(student);
                db.SaveChanges();
            }
            #endregion

            #region Teacher Seed
            var teacherid = Guid.Parse("62c3140d-5464-43e4-96bd-245c89459e60");
            var teacherhased = Common.MD5Hash.Create("Teacher@123");

            var teacher = new User()
            {
                Id = teacherid,
                IsActive = true,
                PasswordHashed = teacherhased,
                UserName = "teacher",
                UserType = Common.UserType.Teacher
            };
            var existingteacher = db.Users.Find(teacher.Id);
            if (existingteacher == null)
            {
                db.Users.Add(teacher);
                db.SaveChanges();
            }
            #endregion
        }
    }
}
