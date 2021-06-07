namespace Broadway.DesktopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fieldsadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerDetails", "Phone", c => c.String());
            AddColumn("dbo.UserDetails", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserDetails", "Email");
            DropColumn("dbo.CustomerDetails", "Phone");
        }
    }
}
