namespace FootballDatabase.Data.Contexts
{
    using System.Data.Entity;
    using FootballDatabase.Models;

    public class SqlServerFootballDbContext : DbContext
    {
        public SqlServerFootballDbContext()
            : base("FootballConnection")
        {
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Trainer> Trainers { get; set; }

        public DbSet<Owner> Owners { get; set; }

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

            modelBuilder.Entity<Team>()
                .HasKey(team => team.Id);

            modelBuilder.Entity<Team>()
                .HasMany<Owner>(team => team.Owners);

            modelBuilder.Entity<Owner>()
                .HasMany<Team>(owner => owner.Teams);
        }
    }
}
