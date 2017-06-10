namespace FootballDatabase.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CountryTeamandTownValidations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Countries", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Teams", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Towns", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Towns", "Name", c => c.Int(nullable: false));
            AlterColumn("dbo.Teams", "Name", c => c.String());
            AlterColumn("dbo.Countries", "Name", c => c.String());
        }
    }
}
