namespace WQuasar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetRoles", "Test", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetRoles", "Test");
        }
    }
}
