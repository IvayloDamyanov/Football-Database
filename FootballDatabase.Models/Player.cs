namespace FootballDatabase.Models
{
    using System.Collections.Generic;

    public class Player
    { 
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Nationality { get; set; }

        public decimal Salary { get; set; }

        public int Contract { get; set; }

        public virtual ICollection<Position> Position { get; set; }

        public virtual Team Team { get; set; }
    }
}
