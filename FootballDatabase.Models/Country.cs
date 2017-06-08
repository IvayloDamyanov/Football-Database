namespace FootballDatabase.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Country
    {
        private const int MinNameLength = 2;
        private const int MaxNameLength = 50;

        public Country()
        {
            this.Towns = new HashSet<Town>();
            this.Teams = new HashSet<Team>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        public virtual ICollection<Town> Towns { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
