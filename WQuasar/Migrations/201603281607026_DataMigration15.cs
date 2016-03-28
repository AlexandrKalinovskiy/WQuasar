namespace WQuasar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration15 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetRoles", "NumberOfThreads", c => c.Int(nullable: false, defaultValue: 1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetRoles", "NumberOfThreads");
        }
    }
}
