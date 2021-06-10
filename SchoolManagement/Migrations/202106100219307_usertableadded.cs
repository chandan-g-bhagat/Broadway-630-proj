namespace SchoolManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usertableadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User_Info",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserName = c.String(),
                        PasswordHashed = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        UserType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User_Info");
        }
    }
}
