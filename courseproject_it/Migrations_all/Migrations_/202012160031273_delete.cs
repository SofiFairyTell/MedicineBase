namespace courseproject_it.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delete : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Освидетельствуемый", "Chairman", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Освидетельствуемый", "Chairman");
        }
    }
}
