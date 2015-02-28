namespace EntityFrameworkExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adres",
                c => new
                    {
                        NrIndeksu = c.Int(nullable: false),
                        Ulica = c.String(),
                        Numerdomu = c.String(name: "Numer domu"),
                        Kodpocztowy = c.String(name: "Kod pocztowy"),
                    })
                .PrimaryKey(t => t.NrIndeksu)
                .ForeignKey("dbo.Student", t => t.NrIndeksu)
                .Index(t => t.NrIndeksu);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        NrIndeksu = c.Int(nullable: false),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                    })
                .PrimaryKey(t => t.NrIndeksu);
            
            CreateTable(
                "dbo.Telefon",
                c => new
                    {
                        PhoneId = c.Int(nullable: false, identity: true),
                        NrIndeksu = c.Int(nullable: false),
                        Numertelefonu = c.Int(name: "Numer telefonu", nullable: false),
                        Operator = c.String(),
                        Komórka = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PhoneId)
                .ForeignKey("dbo.Student", t => t.NrIndeksu, cascadeDelete: true)
                .Index(t => t.NrIndeksu);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telefon", "NrIndeksu", "dbo.Student");
            DropForeignKey("dbo.Adres", "NrIndeksu", "dbo.Student");
            DropIndex("dbo.Telefon", new[] { "NrIndeksu" });
            DropIndex("dbo.Adres", new[] { "NrIndeksu" });
            DropTable("dbo.Telefon");
            DropTable("dbo.Student");
            DropTable("dbo.Adres");
        }
    }
}
