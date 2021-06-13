namespace SchoolManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foreignKeyImplemented : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "UserId", c => c.Guid());
            CreateIndex("dbo.Students", "UserId");
            AddForeignKey("dbo.Students", "UserId", "dbo.User_Info", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "UserId", "dbo.User_Info");
            DropIndex("dbo.Students", new[] { "UserId" });
            DropColumn("dbo.Students", "UserId");
        }
    }
}
