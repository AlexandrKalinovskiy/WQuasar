namespace WQuasar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserServices", "From", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserServices", "To", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserServices", "To");
            DropColumn("dbo.UserServices", "From");
        }
    }
}
