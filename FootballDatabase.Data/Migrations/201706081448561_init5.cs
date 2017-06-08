namespace FootballDatabase.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country_Id = c.Int(),
                        Town_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .ForeignKey("dbo.Towns", t => t.Town_Id)
                .Index(t => t.Country_Id)
                .Index(t => t.Town_Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Nationality = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Contract = c.Int(nullable: false),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.Towns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Nationality = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Contract = c.Int(nullable: false),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Team_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trainers", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Teams", "Town_Id", "dbo.Towns");
            DropForeignKey("dbo.Towns", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Teams", "Country_Id", "dbo.Countries");
            DropIndex("dbo.Trainers", new[] { "Team_Id" });
            DropIndex("dbo.Towns", new[] { "CountryId" });
            DropIndex("dbo.Players", new[] { "Team_Id" });
            DropIndex("dbo.Teams", new[] { "Town_Id" });
            DropIndex("dbo.Teams", new[] { "Country_Id" });
            DropTable("dbo.Trainers");
            DropTable("dbo.Towns");
            DropTable("dbo.Players");
            DropTable("dbo.Teams");
            DropTable("dbo.Countries");
        }
    }
}
