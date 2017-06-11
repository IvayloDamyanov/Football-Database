namespace FootballDatabaseSqlLiteData
{
    using FootballDatabase.Models;
    using FootballDatabaseSqlLiteData.Migrations;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FootballDbSqlLiteContext : DbContext
    {
        public FootballDbSqlLiteContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FootballDbSqlLiteContext, Configuration>(true));
        }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Trainer> Trainers { get; set; }
    }
}
