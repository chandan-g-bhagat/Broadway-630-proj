namespace Broadway.DesktopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class storedProc : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure("SP_CustomerUser", p => new {
                Name = p.String(),
                Address = p.String(),
                Phone = p.String(),
                UserName = p.String(),
                Password = p.String(),
                Email = p.String()
            }, body:
            @"
                declare @userid int

                Insert into user_info (EmailAddress, UserName, Password) values (@Email,@UserName,@Password)
                
                select @userid = SCOPE_IDENTITY()
                
                insert into CustomerDetails (CustomerName, CustomerAddress, Phone,Userid)
                values (@Name, @Address, @Phone, @userid)
        
"

            );
        }
        
        public override void Down()
        {
            DropStoredProcedure("SP_CustomerUser");
        }
    }
}
