namespace FamilyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Models : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Families",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        Origin = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        Family_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Families", t => t.Family_Id)
                .Index(t => t.Family_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "Family_Id", "dbo.Families");
            DropIndex("dbo.Members", new[] { "Family_Id" });
            DropTable("dbo.Members");
            DropTable("dbo.Families");
        }
    }
}
