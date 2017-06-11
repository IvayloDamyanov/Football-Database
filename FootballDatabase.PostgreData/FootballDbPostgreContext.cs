namespace FootballDatabase.PostgreData
{
    using FootballDatabase.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
            base.OnModelCreating(modelBuilder);
        }
    }
}
