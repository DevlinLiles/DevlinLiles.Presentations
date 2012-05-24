namespace Infrastructure.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Activities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkCompleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        WBSItem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("WBSItems", t => t.WBSItem_Id)
                .Index(t => t.WBSItem_Id);
            
            CreateTable(
                "WBSItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Description = c.String(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        Building_Id = c.Int(),
                        Project_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Buildings", t => t.Building_Id)
                .ForeignKey("Projects", t => t.Project_Id)
                .Index(t => t.Building_Id)
                .Index(t => t.Project_Id);
            
            CreateTable(
                "Projects",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ProjectName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("WBSItems", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "Buildings",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("WBSItems", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "WBSItem1",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Color = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Floors",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FloorNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("WBSItems", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("Floors", new[] { "Id" });
            DropIndex("Buildings", new[] { "Id" });
            DropIndex("Projects", new[] { "Id" });
            DropIndex("WBSItems", new[] { "Project_Id" });
            DropIndex("WBSItems", new[] { "Building_Id" });
            DropIndex("Activities", new[] { "WBSItem_Id" });
            DropForeignKey("Floors", "Id", "WBSItems");
            DropForeignKey("Buildings", "Id", "WBSItems");
            DropForeignKey("Projects", "Id", "WBSItems");
            DropForeignKey("WBSItems", "Project_Id", "Projects");
            DropForeignKey("WBSItems", "Building_Id", "Buildings");
            DropForeignKey("Activities", "WBSItem_Id", "WBSItems");
            DropTable("Floors");
            DropTable("WBSItem1");
            DropTable("Buildings");
            DropTable("Projects");
            DropTable("WBSItems");
            DropTable("Activities");
        }
    }
}
