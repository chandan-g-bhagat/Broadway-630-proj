namespace Broadway.DesktopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class maxlength50 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerDetails", "CustomerName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.CustomerDetails", "CustomerAddress", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerDetails", "CustomerAddress", c => c.String());
            AlterColumn("dbo.CustomerDetails", "CustomerName", c => c.String(nullable: false));
        }
    }
}
