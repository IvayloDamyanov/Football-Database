namespace FootballDatabase.Models
{
    using System.Collections.Generic;

    public class Country
    {
        public int CountryId { get; set; }

        public string CountryName { get; set; }

        public virtual ICollection<Town> Towns { get; set; }

        public virtual ICollection<FootballTeam> FootballTeams { get; set; }
    }
}
