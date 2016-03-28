namespace WQuasar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetRoles", "NumberOfThreads", c => c.Int());
            AddColumn("dbo.AspNetRoles", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetRoles", "Discriminator");
            DropColumn("dbo.AspNetRoles", "NumberOfThreads");
        }
    }
}
