namespace WQuasar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.UserServices", newName: "UserService1");
            CreateTable(
                "dbo.UserServices",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Service_Id = c.Int(nullable: false),
                        To = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Service_Id });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserServices");
            RenameTable(name: "dbo.UserService1", newName: "UserServices");
        }
    }
}
