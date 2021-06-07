namespace Broadway.DesktopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usertableremoved : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.User_Info");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.User_Info",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
