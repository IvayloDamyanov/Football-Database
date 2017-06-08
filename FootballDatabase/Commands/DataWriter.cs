using FootballDatabase.Data;
using FootballDatabase.Models;

namespace FootballDatabase.Commands
{
    public class DataWriter
    {
        private FootballDbContext dbContext;
        private Player[] players = JSONReader.ReadPlayers("../../../FootballDatabase/Data/players.json");
        private Country[] countries = JSONReader.ReadCountries("../../../FootballDatabase/Data/countries.json");
        private Town[] towns = JSONReader.ReadTowns("../../../FootballDatabase/Data/towns.json");

        public DataWriter(FootballDbContext context)
        {
            this.DbContext = context;
        }

        public FootballDbContext DbContext
        {
            get { return this.dbContext; }
            private set { this.dbContext = value; }
        }

        public void Populate()
        {
            this.AddPlayers(this.DbContext, this.players);
            this.AddCountries(this.DbContext, this.countries);
            this.AddTowns(this.DbContext, this.towns);
        }

        public void AddPlayers(FootballDbContext context, Player[] players)
        {
            for (int i = 0; i < players.Length; i += 1)
            {
                context.Players.Add(players[i]);
            }

            context.SaveChanges();
        }

        public void AddCountries(FootballDbContext context, Country[] countries)
        {
            for (int i = 0; i < countries.Length; i += 1)
            {
                context.Countries.Add(countries[i]);
            }

            context.SaveChanges();
        }

        public void AddTowns(FootballDbContext context, Town[] towns)
        {
            for (int i = 0; i < towns.Length; i += 1)
            {
                context.Towns.Add(towns[i]);
            }

            context.SaveChanges();
        }
    }
}
