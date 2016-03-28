namespace WQuasar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration12 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetRoles", "NumberOfThreads");
            DropColumn("dbo.AspNetRoles", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetRoles", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.AspNetRoles", "NumberOfThreads", c => c.Int());
        }
    }
}
