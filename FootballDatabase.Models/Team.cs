namespace FootballDatabase.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Team
    {
        public Team()
        {
            this.Players = new HashSet<Player>();
            this.IsDeleted = false;
        }

        private const int MinNameLength = 2;
        private const int MaxNameLength = 50;

        public int Id { get; set; }

        [Required]
        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        public int TownId { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Town Town { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public override string ToString()
        {
            //return this.Team.Name; check how to extract team's town name, players, etc.

            return string.Format($@"Id: {this.Id}, Name: {this.Name}");
        }
    }
}
