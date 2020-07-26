﻿namespace ShopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddnewtabletblUsersRoles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblUsersRoles",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.tblRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.tblUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblUsersRoles", "UserId", "dbo.tblUsers");
            DropForeignKey("dbo.tblUsersRoles", "RoleId", "dbo.tblRoles");
            DropIndex("dbo.tblUsersRoles", new[] { "RoleId" });
            DropIndex("dbo.tblUsersRoles", new[] { "UserId" });
            DropTable("dbo.tblUsersRoles");
        }
    }
}
