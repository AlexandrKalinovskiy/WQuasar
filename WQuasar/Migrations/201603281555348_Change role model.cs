namespace WQuasar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changerolemodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetRoles", "NumberOfThreads", c => c.Int());
            DropColumn("dbo.AspNetRoles", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetRoles", "Description", c => c.String());
            DropColumn("dbo.AspNetRoles", "NumberOfThreads");
        }
    }
}
