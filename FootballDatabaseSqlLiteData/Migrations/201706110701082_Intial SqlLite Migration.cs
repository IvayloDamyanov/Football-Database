namespace FootballDatabaseSqlLiteData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialSqlLiteMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Age = c.Int(nullable: false),
                        Nationality = c.String(maxLength: 50),
                        Salary = c.Decimal(precision: 18, scale: 2),
                        Contract = c.Int(),
                        TeamId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Position = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        TownId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Towns", t => t.TownId, cascadeDelete: true)
                .Index(t => t.TownId);
            
            CreateTable(
                "dbo.Towns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        CountryId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Nationality = c.String(),
                        Salary = c.Decimal(precision: 18, scale: 2),
                        Contract = c.Int(),
                        TeamId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trainers", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Teams", "TownId", "dbo.Towns");
            DropForeignKey("dbo.Towns", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropIndex("dbo.Trainers", new[] { "TeamId" });
            DropIndex("dbo.Towns", new[] { "CountryId" });
            DropIndex("dbo.Teams", new[] { "TownId" });
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropTable("dbo.Trainers");
            DropTable("dbo.Countries");
            DropTable("dbo.Towns");
            DropTable("dbo.Teams");
            DropTable("dbo.Players");
        }
    }
}
