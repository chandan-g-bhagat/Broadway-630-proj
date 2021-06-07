namespace Broadway.DesktopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedUser : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.UserDetails");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserDetails",
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
