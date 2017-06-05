namespace FootballDatabase.Models
{
    using System.Collections.Generic;

    public class FootballPlayer
    { 
        public int FootballPlayerId { get; set; }

        public string FootballPlayerName { get; set; }

        public int Age { get; set; }

        public string Nationality { get; set; }

        public decimal Salary { get; set; }

        public int Contract { get; set; }

        public virtual ICollection<Position> Position { get; set; }

        public virtual FootballTeam FootballTeam { get; set; }
    }
}
