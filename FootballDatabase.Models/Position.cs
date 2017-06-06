﻿namespace FootballDatabase.Models
{
    using System.Collections.Generic;

    public class Position
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
