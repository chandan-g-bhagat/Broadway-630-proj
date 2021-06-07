namespace Broadway.DesktopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foreignKeyAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerDetails", "Userid", c => c.Int());
            CreateIndex("dbo.CustomerDetails", "Userid");
            AddForeignKey("dbo.CustomerDetails", "Userid", "dbo.User_Info", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerDetails", "Userid", "dbo.User_Info");
            DropIndex("dbo.CustomerDetails", new[] { "Userid" });
            DropColumn("dbo.CustomerDetails", "Userid");
        }
    }
}
