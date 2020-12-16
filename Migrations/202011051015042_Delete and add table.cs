namespace courseproject_it.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deleteandaddtable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Категория годности", "Person_Id", "dbo.Освидетельствуемый");
            DropIndex("dbo.Категория годности", new[] { "Person_Id" });
            AddColumn("dbo.Освидетельствуемый", "Имя", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Отчество", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Фамилия", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Категория_освидетельствуемого", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Воинское_звание", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Дата_рождения", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Статья_Требование", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Статья_Расписание", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Диагноз", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Категория_годности", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Заключение", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Заключение_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Освидетельствуемый", "Заключение_Дата", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Заключение_Причина", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Примечение", c => c.String());
            DropColumn("dbo.Освидетельствуемый", "Name");
            DropColumn("dbo.Освидетельствуемый", "Middlename");
            DropColumn("dbo.Освидетельствуемый", "Surname");
            DropColumn("dbo.Освидетельствуемый", "Category_Person");
            DropColumn("dbo.Освидетельствуемый", "Arm_Status");
            DropColumn("dbo.Освидетельствуемый", "Birthday");
            DropColumn("dbo.Освидетельствуемый", "Article_Trebovanie");
            DropColumn("dbo.Освидетельствуемый", "Article_Raspisanie");
            DropColumn("dbo.Освидетельствуемый", "Diagnos");
            DropColumn("dbo.Освидетельствуемый", "Category_Godnost");
            DropColumn("dbo.Освидетельствуемый", "Result");
            DropColumn("dbo.Освидетельствуемый", "Result_Id");
            DropColumn("dbo.Освидетельствуемый", "Result_Date");
            DropColumn("dbo.Освидетельствуемый", "Result_Prichina");
            DropColumn("dbo.Освидетельствуемый", "Other");
            DropTable("dbo.Категория годности");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Категория годности",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Description = c.String(),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Освидетельствуемый", "Other", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Result_Prichina", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Result_Date", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Result_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Освидетельствуемый", "Result", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Category_Godnost", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Diagnos", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Article_Raspisanie", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Article_Trebovanie", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Birthday", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Arm_Status", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Category_Person", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Surname", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Middlename", c => c.String());
            AddColumn("dbo.Освидетельствуемый", "Name", c => c.String());
            DropColumn("dbo.Освидетельствуемый", "Примечение");
            DropColumn("dbo.Освидетельствуемый", "Заключение_Причина");
            DropColumn("dbo.Освидетельствуемый", "Заключение_Дата");
            DropColumn("dbo.Освидетельствуемый", "Заключение_ID");
            DropColumn("dbo.Освидетельствуемый", "Заключение");
            DropColumn("dbo.Освидетельствуемый", "Категория_годности");
            DropColumn("dbo.Освидетельствуемый", "Диагноз");
            DropColumn("dbo.Освидетельствуемый", "Статья_Расписание");
            DropColumn("dbo.Освидетельствуемый", "Статья_Требование");
            DropColumn("dbo.Освидетельствуемый", "Дата_рождения");
            DropColumn("dbo.Освидетельствуемый", "Воинское_звание");
            DropColumn("dbo.Освидетельствуемый", "Категория_освидетельствуемого");
            DropColumn("dbo.Освидетельствуемый", "Фамилия");
            DropColumn("dbo.Освидетельствуемый", "Отчество");
            DropColumn("dbo.Освидетельствуемый", "Имя");
            CreateIndex("dbo.Категория годности", "Person_Id");
            AddForeignKey("dbo.Категория годности", "Person_Id", "dbo.Освидетельствуемый", "Id");
        }
    }
}
