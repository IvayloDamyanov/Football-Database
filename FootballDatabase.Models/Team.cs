namespace FootballDatabase.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Team
    {
        private const int MinNameLength = 2;
        private const int MaxNameLength = 50;

        public int Id { get; set; }

        [Required]
        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        public virtual Town Town { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
