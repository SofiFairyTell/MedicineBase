namespace courseproject_it.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Освидетельствуемый",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Middlename = c.String(),
                        Surname = c.String(),
                        Category_Person = c.String(),
                        Arm_Status = c.String(),
                        Birthday = c.String(),
                        Article_Trebovanie = c.String(),
                        Article_Raspisanie = c.String(),
                        Diagnos = c.String(),
                        Category_Godnost = c.String(),
                        Result = c.String(),
                        Result_Id = c.Int(nullable: false),
                        Result_Date = c.String(),
                        Result_Prichina = c.String(),
                        Other = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
                "dbo.Категория годности",
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
            DropForeignKey("dbo.Категория годности", "Person_Id", "dbo.Освидетельствуемый");
            DropForeignKey("dbo.Категория освидетельствуемого", "Person_Id", "dbo.Освидетельствуемый");
            DropIndex("dbo.Причинно-следственные связи", new[] { "Person_Id" });
            DropIndex("dbo.Воинское звание", new[] { "Person_Id" });
            DropIndex("dbo.Категория годности", new[] { "Person_Id" });
            DropIndex("dbo.Категория освидетельствуемого", new[] { "Person_Id" });
            DropTable("dbo.Причинно-следственные связи");
            DropTable("dbo.Воинское звание");
            DropTable("dbo.Категория годности");
            DropTable("dbo.Категория освидетельствуемого");
            DropTable("dbo.Освидетельствуемый");
        }
    }
}
