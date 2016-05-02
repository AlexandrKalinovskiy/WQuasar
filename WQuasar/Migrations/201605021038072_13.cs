namespace WQuasar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _13 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SubscriptionServices", "Subscription_Id", "dbo.Subscriptions");
            DropForeignKey("dbo.SubscriptionServices", "Service_Id", "dbo.Services");
            DropIndex("dbo.SubscriptionServices", new[] { "Subscription_Id" });
            DropIndex("dbo.SubscriptionServices", new[] { "Service_Id" });
            AddColumn("dbo.Services", "Subscription_Id", c => c.Int());
            CreateIndex("dbo.Services", "Subscription_Id");
            AddForeignKey("dbo.Services", "Subscription_Id", "dbo.Subscriptions", "Id");
            DropTable("dbo.SubscriptionServices");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SubscriptionServices",
                c => new
                    {
                        Subscription_Id = c.Int(nullable: false),
                        Service_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Subscription_Id, t.Service_Id });
            
            DropForeignKey("dbo.Services", "Subscription_Id", "dbo.Subscriptions");
            DropIndex("dbo.Services", new[] { "Subscription_Id" });
            DropColumn("dbo.Services", "Subscription_Id");
            CreateIndex("dbo.SubscriptionServices", "Service_Id");
            CreateIndex("dbo.SubscriptionServices", "Subscription_Id");
            AddForeignKey("dbo.SubscriptionServices", "Service_Id", "dbo.Services", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SubscriptionServices", "Subscription_Id", "dbo.Subscriptions", "Id", cascadeDelete: true);
        }
    }
}
