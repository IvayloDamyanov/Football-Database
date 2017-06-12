namespace FootballDatabase.Data.PostgreSqlMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "OwnerId", c => c.Int(nullable: false));
            AddColumn("dbo.Owners", "TeamId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Owners", "TeamId");
            DropColumn("dbo.Teams", "OwnerId");
        }
    }
}
