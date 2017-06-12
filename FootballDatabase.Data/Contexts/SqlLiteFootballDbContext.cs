namespace FootballDatabase.Data.Contexts
{
    using FootballDatabase.Models;
    using System.Data.Entity;
    using FootballDatabase.Data.SqlLiteMigrations;

    public class SqlLiteFootballDbContext : DbContext
    {
        public SqlLiteFootballDbContext()
            :base("SqliteDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SqlLiteFootballDbContext, SqlLiteConfiguration>(true));
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Trainer> Trainers { get; set; }

        private void OnTrainerModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trainer>()
                .HasKey(trainer => trainer.Id);

            modelBuilder.Entity<Trainer>()
                .Property(trainer => trainer.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Trainer>()
                .Property(trainer => trainer.Age)
                .IsRequired();

            modelBuilder.Entity<Trainer>()
                .Property(trainer => trainer.Nationality)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
