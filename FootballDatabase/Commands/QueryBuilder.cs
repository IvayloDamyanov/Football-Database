using FootballDatabase.Data;
using FootballDatabase.Models;
using System.Linq;

namespace FootballDatabase.Commands
{
    public class QueryBuilder
    {
        private FootballDbContext context;

        public QueryBuilder(FootballDbContext context)
        {
            this.Context = context;
        }

        public FootballDbContext Context
        {
            get
            {
                return this.context;
            }

            set
            {
                this.context = value;
            }
        }

        public string AddQuery (string tableName, int id)
        {
            string output = "";

            switch (tableName)
            {
                case "Countries":
                    output = this.CountryQuery(id).ToString();
                    break;
                case "Towns":
                    output = this.TownQuery(id).ToString();
                    break;
                case "Players":
                    output = this.PlayerQuery(id).ToString();
                    break;
                case "Teams":
                    output = this.TeamQuery(id).ToString();
                    break;
                case "Trainers":
                    output = this.TrainerQuery(id).ToString();
                    break;
                default:
                    output = "empty query";
                    break;
            }

            return output;
        }

        public void DeleteQuery(string tableName, int id)
        {
            switch (tableName)
            {
                case "Countries":
                    this.CountryQuery(id).IsDeleted = true;
                    break;
                case "Towns":
                    this.TownQuery(id).IsDeleted = true;
                    break;
                case "Players":
                    this.PlayerQuery(id).IsDeleted = true;
                    break;
                case "Teams":
                    this.TeamQuery(id).IsDeleted = true;
                    break;
                case "Trainers":
                    this.TrainerQuery(id).IsDeleted = true;
                    break;
                default:
                    break;
            }
        }

        public Country CountryQuery(int id)
        {
            Country outputCountry = new Country();
            
            try
            {
                var query = (from country in this.Context.Countries where country.Id == id select country);
                outputCountry = query.First();
            }
            catch
            {

            }
            
            return outputCountry;
        }

        public Town TownQuery(int id)
        {
            Town outputTown = new Town();

            try
            {
                var query = (from town in this.Context.Towns where town.Id == id select town);
                outputTown = query.First();
            }
            catch
            {

            }
            

            return outputTown;
        }

        public Player PlayerQuery(int id)
        {
            Player outputPlayer = new Player();

            try
            {
                var query = (from player in this.Context.Players where player.Id == id select player);
                outputPlayer = query.First();
            }
            catch
            {

            }
            
            return outputPlayer;
        }

        public Team TeamQuery(int id)
        {
            Team outputTeam = new Team();

            try
            {
                var query = (from team in this.Context.Teams where team.Id == id select team);
                outputTeam = query.First();
            }
            catch
            {

            }
            
            return outputTeam;
        }

        public Trainer TrainerQuery(int id)
        {
            Trainer outputTrainer = new Trainer();
            try
            {
                var query = (from trainer in this.Context.Trainers where trainer.Id == id select trainer);
                outputTrainer = query.First();
            }
            catch
            {

            }
            
            return outputTrainer;
        }
    }
}
