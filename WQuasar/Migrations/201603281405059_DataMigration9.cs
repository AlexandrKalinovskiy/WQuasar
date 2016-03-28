namespace WQuasar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration9 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetRoles", "Test");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetRoles", "Test", c => c.Int());
        }
    }
}
