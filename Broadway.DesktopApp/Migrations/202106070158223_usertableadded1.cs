namespace Broadway.DesktopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usertableadded1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User_Info",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmailAddress = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User_Info");
        }
    }
}
