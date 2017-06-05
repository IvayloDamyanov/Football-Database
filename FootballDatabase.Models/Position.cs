namespace FootballDatabase.Models
{
    using System.Collections.Generic;

    public class Position
    {
        public int PositionId { get; set; }

        public string PositionName { get; set; }

        public virtual ICollection<FootballPlayer> Players { get; set; }
    }
}
