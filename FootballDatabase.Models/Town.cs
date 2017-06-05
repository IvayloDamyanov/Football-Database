namespace FootballDatabase.Models
{
    using System.Collections.Generic;

    public class Town
    {
        public int TownId { get; set; }

        public int TownName { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<FootballTeam> FootballTeams { get; set; }
    }
}
