namespace WQuasar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subscriptions", "Description", c => c.String());
            AddColumn("dbo.Subscriptions", "Period", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subscriptions", "Period");
            DropColumn("dbo.Subscriptions", "Description");
        }
    }
}
