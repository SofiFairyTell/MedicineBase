namespace courseproject_it.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewTables : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Person", newName: "Освидетельствуемый");
            CreateTable(
                "dbo.Категория освидетельствуемого",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Description = c.String(),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Освидетельствуемый", t => t.Person_Id)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.Воинское звание",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                        Description = c.String(),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Освидетельствуемый", t => t.Person_Id)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.Причинно-следственные связи",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Prichina = c.String(),
                        Description = c.String(),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Освидетельствуемый", t => t.Person_Id)
                .Index(t => t.Person_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Причинно-следственные связи", "Person_Id", "dbo.Освидетельствуемый");
            DropForeignKey("dbo.Воинское звание", "Person_Id", "dbo.Освидетельствуемый");
            DropForeignKey("dbo.Категория освидетельствуемого", "Person_Id", "dbo.Освидетельствуемый");
            DropIndex("dbo.Причинно-следственные связи", new[] { "Person_Id" });
            DropIndex("dbo.Воинское звание", new[] { "Person_Id" });
            DropIndex("dbo.Категория освидетельствуемого", new[] { "Person_Id" });
            DropTable("dbo.Причинно-следственные связи");
            DropTable("dbo.Воинское звание");
            DropTable("dbo.Категория освидетельствуемого");
            RenameTable(name: "dbo.Освидетельствуемый", newName: "Person");
        }
    }
}
