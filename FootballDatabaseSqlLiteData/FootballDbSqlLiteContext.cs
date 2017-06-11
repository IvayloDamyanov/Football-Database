namespace FootballDatabaseSqlLiteData
{
    using FootballDatabase.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
