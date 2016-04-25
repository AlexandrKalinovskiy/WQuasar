namespace WQuasar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ApplicationUserServices", newName: "UserServices");
            RenameColumn(table: "dbo.UserServices", name: "ApplicationUser_Id", newName: "User_Id");
            RenameIndex(table: "dbo.UserServices", name: "IX_ApplicationUser_Id", newName: "IX_User_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.UserServices", name: "IX_User_Id", newName: "IX_ApplicationUser_Id");
            RenameColumn(table: "dbo.UserServices", name: "User_Id", newName: "ApplicationUser_Id");
            RenameTable(name: "dbo.UserServices", newName: "ApplicationUserServices");
        }
    }
}
