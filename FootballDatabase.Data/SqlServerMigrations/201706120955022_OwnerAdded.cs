namespace FootballDatabase.Data.SqlServerMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OwnerAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Nationality = c.String(maxLength: 50),
                        Age = c.Int(nullable: false),
                        Incomes = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OwnerTeams",
                c => new
                    {
                        Owner_Id = c.Int(nullable: false),
                        Team_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Owner_Id, t.Team_Id })
                .ForeignKey("dbo.Owners", t => t.Owner_Id, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.Team_Id, cascadeDelete: true)
                .Index(t => t.Owner_Id)
                .Index(t => t.Team_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OwnerTeams", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.OwnerTeams", "Owner_Id", "dbo.Owners");
            DropIndex("dbo.OwnerTeams", new[] { "Team_Id" });
            DropIndex("dbo.OwnerTeams", new[] { "Owner_Id" });
            DropTable("dbo.OwnerTeams");
            DropTable("dbo.Owners");
        }
    }
}
