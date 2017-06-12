namespace FootballDatabase.Client.Commands
{
    using FootballDatabase.Data.Contexts;
    using FootballDatabase.Models;
    using FootballDatabase.Utils;

    public class DataWriter
    {
        private SqlServerFootballDbContext dbContext;
        private Country[] countries;
        private Town[] towns;
        private Team[] teams;
        private Player[] players;
        private Trainer[] trainers;
        private Owner[] owners;

        public DataWriter(SqlServerFootballDbContext context)
        {
            this.DbContext = context;
            this.ReadData();
        }

        private void ReadData()
        {
            this.countries = JSONParser.ReadCountries("../../../FootballDatabase/Data/countries.json");
            this.towns = JSONParser.ReadTowns("../../../FootballDatabase/Data/towns.json");
            this.teams = JSONParser.ReadTeams("../../../FootballDatabase/Data/teams.json");
            this.players = JSONParser.ReadPlayers("../../../FootballDatabase/Data/players.json");
            this.trainers = XMLParser.ReadTrainers("../../../FootballDatabase/Data/trainers.xml");
            this.owners = JSONParser.ReadOwners("../../../FootballDatabase/Data/owners.json");
        }

        public SqlServerFootballDbContext DbContext
        {
            get { return this.dbContext; }
            private set { this.dbContext = value; }
        }

        public void Populate()
        {
            this.AddCountries(this.DbContext, this.countries);
            this.AddTowns(this.DbContext, this.towns);
            this.AddTeams(this.DbContext, this.teams);
            this.AddPlayers(this.DbContext, this.players);
            this.AddTrainers(this.DbContext, this.trainers);
            this.AddOwners(this.DbContext, this.owners);
        }

        public void AddCountries(SqlServerFootballDbContext context, Country[] countries)
        {
            for (int i = 0; i < countries.Length; i++)
            {
                context.Countries.Add(countries[i]);
            }

            context.SaveChanges();
        }

        public void AddTowns(SqlServerFootballDbContext context, Town[] towns)
        {
            for (int i = 0; i < towns.Length; i++)
            {
                context.Towns.Add(towns[i]);
            }

            context.SaveChanges();
        }

        public void AddTeams(SqlServerFootballDbContext context, Team[] teams)
        {
            for (int i = 0; i < teams.Length; i++)
            {
                context.Teams.Add(teams[i]);
            }

            context.SaveChanges();
        }

        public void AddPlayers(SqlServerFootballDbContext context, Player[] players)
        {
            for (int i = 0; i < players.Length; i++)
            {
                context.Players.Add(players[i]);
            }

            context.SaveChanges();
        }

        public void AddTrainers(SqlServerFootballDbContext context, Trainer[] trainers)
        {
            for (int i = 0; i < trainers.Length; i++)
            {
                context.Trainers.Add(trainers[i]);
            }

            context.SaveChanges();
        }

        public void AddOwners(SqlServerFootballDbContext context, Owner[] trainers)
        {
            for (int i = 0; i < trainers.Length; i++)
            {
                context.Owners.Add(owners[i]);
            }

            context.SaveChanges();
        }
    }
}