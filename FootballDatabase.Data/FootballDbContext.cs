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
            this.OnTrainerModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("public");

            //modelBuilder.Entity<Trainer>().HasKey(x => x.Id);
            //modelBuilder.Entity<Player>().HasRequired(x => x.Name);
            base.OnModelCreating(modelBuilder);
        }

        private void OnTrainerModelCreating (DbModelBuilder modelBuilder)
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
