namespace FootballDatabase.Data
{
    using FootballDatabase.Models;
    using System.Data.Entity;

    public class FootballDbContext : DbContext
    {
        public FootballDbContext()
            : base("FootballConnection")
        {
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Trainer> Trainers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");

            modelBuilder.Entity<Player>().HasKey(x => x.Id);
            //modelBuilder.Entity<Player>().HasRequired(x => x.Name);

            base.OnModelCreating(modelBuilder);
        }
    }
}
