namespace SchoolManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class subjectsAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        RoomNumber = c.String(),
                        ClassTeacherId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.ClassTeacherId)
                .Index(t => t.ClassTeacherId);
            
            AddColumn("dbo.Students", "ClassId", c => c.Guid());
            CreateIndex("dbo.Students", "ClassId");
            AddForeignKey("dbo.Students", "ClassId", "dbo.Classes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.Classes", "ClassTeacherId", "dbo.Teachers");
            DropIndex("dbo.Classes", new[] { "ClassTeacherId" });
            DropIndex("dbo.Students", new[] { "ClassId" });
            DropColumn("dbo.Students", "ClassId");
            DropTable("dbo.Classes");
        }
    }
}
