namespace FootballDatabase.Models
{
    using System.Collections.Generic;

    public class FootballTeam
    {
        public int FootballTeamId { get; set; }

        public string FootballTeamName { get; set; }

        public virtual Town Town { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<FootballPlayer> FootballPlayers { get; set; }
    }
}
