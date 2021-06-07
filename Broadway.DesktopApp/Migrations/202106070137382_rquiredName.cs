namespace Broadway.DesktopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rquiredName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerDetails", "CustomerName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerDetails", "CustomerName", c => c.String());
        }
    }
}
