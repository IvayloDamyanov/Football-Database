namespace FootballDatabase.Data
{
    using FootballDatabase.Models;
    using System.Data.Entity;

    public class FootballDbContext : DbContext
    {
        public FootballDbContext()
            : base("FootballDb")
        {
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Position> Positions { get; set; }
    }
}
