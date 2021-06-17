namespace SchoolManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class subjectAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subjects",
                c => new
                {
                    Id = c.Guid(nullable: false),
                    Name = c.String(),
                    Code = c.String(),
                    ClassId = c.Guid(),
                    TeacherId = c.Guid(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClassId)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.ClassId)
                .Index(t => t.TeacherId);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Subjects", "ClassId", "dbo.Classes");
            DropIndex("dbo.Subjects", new[] { "TeacherId" });
            DropIndex("dbo.Subjects", new[] { "ClassId" });
            DropTable("dbo.Subjects");
        }
    }
}