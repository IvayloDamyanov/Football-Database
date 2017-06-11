namespace FootballDatabaseSqlLiteData
{
    using System.Data.Entity;
    using FootballDatabase.Models;

    public class FootballDbSqlLiteContext : DbContext
    {
        public FootballDbSqlLiteContext()
            : base("SqliteDb")
        {
        }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Trainer> Trainers { get; set; }
    }
}
