namespace ShopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddtblUsersRolesrenametblUserRoles : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.tblUsersRoles", newName: "tblUserRoles");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.tblUserRoles", newName: "tblUsersRoles");
        }
    }
}
