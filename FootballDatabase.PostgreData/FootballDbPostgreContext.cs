namespace FootballDatabase.PostgreData
{
    using System.Data.Entity;
    using FootballDatabase.Models;

    public class FootballDbPostgreContext : DbContext
    {
        public FootballDbPostgreContext()
            : base("PgsqlDb")
        {
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Town> Towns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");

            base.OnModelCreating(modelBuilder);
        }
    }
}
