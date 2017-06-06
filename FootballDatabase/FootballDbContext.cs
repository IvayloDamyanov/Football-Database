using System.Data.Entity;
using FootballDatabase.Models;

namespace FootballDatabase
{
    class FootballDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Position> Positions { get; set; }
    }
}
