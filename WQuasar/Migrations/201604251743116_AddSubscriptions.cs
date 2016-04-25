namespace WQuasar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSubscriptions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subscriptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ServiceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Services", "Subscription_Id", c => c.Int());
            CreateIndex("dbo.Services", "Subscription_Id");
            AddForeignKey("dbo.Services", "Subscription_Id", "dbo.Subscriptions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Services", "Subscription_Id", "dbo.Subscriptions");
            DropIndex("dbo.Services", new[] { "Subscription_Id" });
            DropColumn("dbo.Services", "Subscription_Id");
            DropTable("dbo.Subscriptions");
        }
    }
}
