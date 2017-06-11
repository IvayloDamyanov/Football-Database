namespace FootballDatabase.PostgreData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.Towns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        CountryId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "public.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        TownId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Towns", t => t.TownId, cascadeDelete: true)
                .Index(t => t.TownId);
            
            CreateTable(
                "public.Players",
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
                .ForeignKey("public.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.Teams", "TownId", "public.Towns");
            DropForeignKey("public.Players", "TeamId", "public.Teams");
            DropForeignKey("public.Towns", "CountryId", "public.Countries");
            DropIndex("public.Players", new[] { "TeamId" });
            DropIndex("public.Teams", new[] { "TownId" });
            DropIndex("public.Towns", new[] { "CountryId" });
            DropTable("public.Players");
            DropTable("public.Teams");
            DropTable("public.Towns");
            DropTable("public.Countries");
        }
    }
}
