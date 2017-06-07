namespace FootballDatabase
{
    using System.Data.Entity;
    using FootballDatabase.Models;

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
