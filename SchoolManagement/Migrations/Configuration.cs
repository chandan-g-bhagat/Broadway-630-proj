namespace SchoolManagement.Migrations
{
    using SchoolManagement.Common;
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
            var adminId = Guid.Parse("edf279fd-934a-428b-981e-36e002efd07e");
            var passwordHased = MD5Hash.Create("admin123");
            var admin = new User
            {
                Id = adminId,
                UserName = "admin",
                PasswordHashed = passwordHased,
                IsActive = true,
                UserType = UserType.Admin
            };
            var existing = db.Users.Find(admin.Id);
            if (existing==null)
            {
                db.Users.Add(admin);
                db.SaveChanges();
            }
            else
            {
                //todo
            }
        }
    }
}
