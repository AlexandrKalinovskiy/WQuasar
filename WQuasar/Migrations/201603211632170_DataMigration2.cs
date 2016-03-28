namespace WQuasar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Active", c => c.Boolean(nullable: false));
            DropColumn("dbo.AspNetUsers", "UserActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "UserActive", c => c.Boolean(nullable: false));
            DropColumn("dbo.AspNetUsers", "Active");
        }
    }
}
