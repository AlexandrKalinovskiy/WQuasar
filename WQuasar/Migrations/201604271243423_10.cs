namespace WQuasar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _10 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserServices", "From");
            DropColumn("dbo.UserServices", "To");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserServices", "To", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserServices", "From", c => c.DateTime(nullable: false));
        }
    }
}
