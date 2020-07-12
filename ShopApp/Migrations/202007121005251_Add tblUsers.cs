namespace ShopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddtblUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Image = c.String(nullable: false, maxLength: 150),
                        MobilePhoneNumber = c.String(nullable: false, maxLength: 20),
                        DateRegistered = c.DateTime(nullable: false),
                        LastLoginDate = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        Email = c.String(nullable: false, maxLength: 150),
                        Password = c.String(nullable: false, maxLength: 150),
                        PasswordHash = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblUsers");
        }
    }
}
