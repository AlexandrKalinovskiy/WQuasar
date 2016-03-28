namespace WQuasar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration14 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetRoles", "NumberOfThreads");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetRoles", "NumberOfThreads", c => c.Int());
        }
    }
}
