namespace Zaj02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Formularz",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(),
                        AuthorLastName = c.String(),
                        AuthorEmail = c.String(),
                        SubAuthorName = c.String(),
                        SubAuthorLastName = c.String(),
                        DefenderName = c.String(),
                        DefenderLastName = c.String(),
                        UniversityName = c.String(),
                        UniversityAddress = c.String(),
                        ReportTitle = c.String(),
                        ReportSummary = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Formularz");
        }
    }
}
