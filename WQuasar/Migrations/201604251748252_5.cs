namespace WQuasar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Subscriptions", "ServiceId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subscriptions", "ServiceId", c => c.Int(nullable: false));
        }
    }
}
