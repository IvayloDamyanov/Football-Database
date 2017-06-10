namespace FootballDatabase.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlayerValidations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Players", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Players", "Nationality", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Players", "Nationality", c => c.String());
            AlterColumn("dbo.Players", "Name", c => c.String());
        }
    }
}
