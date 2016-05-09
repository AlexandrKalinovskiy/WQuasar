namespace WQuasar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _17 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subscriptions", "CssClass", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subscriptions", "CssClass");
        }
    }
}
