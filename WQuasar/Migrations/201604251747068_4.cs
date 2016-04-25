namespace WQuasar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Services", "Subscription_Id", "dbo.Subscriptions");
            DropIndex("dbo.Services", new[] { "Subscription_Id" });
            CreateTable(
                "dbo.SubscriptionServices",
                c => new
                    {
                        Subscription_Id = c.Int(nullable: false),
                        Service_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Subscription_Id, t.Service_Id })
                .ForeignKey("dbo.Subscriptions", t => t.Subscription_Id, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.Service_Id, cascadeDelete: true)
                .Index(t => t.Subscription_Id)
                .Index(t => t.Service_Id);
            
            DropColumn("dbo.Services", "Subscription_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "Subscription_Id", c => c.Int());
            DropForeignKey("dbo.SubscriptionServices", "Service_Id", "dbo.Services");
            DropForeignKey("dbo.SubscriptionServices", "Subscription_Id", "dbo.Subscriptions");
            DropIndex("dbo.SubscriptionServices", new[] { "Service_Id" });
            DropIndex("dbo.SubscriptionServices", new[] { "Subscription_Id" });
            DropTable("dbo.SubscriptionServices");
            CreateIndex("dbo.Services", "Subscription_Id");
            AddForeignKey("dbo.Services", "Subscription_Id", "dbo.Subscriptions", "Id");
        }
    }
}
