namespace Zaj02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialmigration2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Formularz", "AuthorName", c => c.String(nullable: false));
            AlterColumn("dbo.Formularz", "AuthorLastName", c => c.String(nullable: false));
            AlterColumn("dbo.Formularz", "AuthorEmail", c => c.String(nullable: false));
            AlterColumn("dbo.Formularz", "DefenderName", c => c.String(nullable: false));
            AlterColumn("dbo.Formularz", "DefenderLastName", c => c.String(nullable: false));
            AlterColumn("dbo.Formularz", "UniversityName", c => c.String(nullable: false));
            AlterColumn("dbo.Formularz", "UniversityAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Formularz", "ReportTitle", c => c.String(nullable: false));
            AlterColumn("dbo.Formularz", "ReportSummary", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Formularz", "ReportSummary", c => c.String());
            AlterColumn("dbo.Formularz", "ReportTitle", c => c.String());
            AlterColumn("dbo.Formularz", "UniversityAddress", c => c.String());
            AlterColumn("dbo.Formularz", "UniversityName", c => c.String());
            AlterColumn("dbo.Formularz", "DefenderLastName", c => c.String());
            AlterColumn("dbo.Formularz", "DefenderName", c => c.String());
            AlterColumn("dbo.Formularz", "AuthorEmail", c => c.String());
            AlterColumn("dbo.Formularz", "AuthorLastName", c => c.String());
            AlterColumn("dbo.Formularz", "AuthorName", c => c.String());
        }
    }
}
