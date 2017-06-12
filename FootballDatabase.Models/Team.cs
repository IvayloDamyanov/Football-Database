namespace FootballDatabase.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Team
    {
        private const int MinNameLength = 2;
        private const int MaxNameLength = 50;

        public Team()
        {
            this.Players = new HashSet<Player>();
            this.Owners = new HashSet<Owner>();
            this.IsDeleted = false;
        }

        public int Id { get; set; }

        [Required]
        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        public int TownId { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Town Town { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Owner> Owners { get; set; }

        public override string ToString()
        {
            return string.Format($@"Id: {this.Id}, Name: {this.Name}");
        }
    }
}
