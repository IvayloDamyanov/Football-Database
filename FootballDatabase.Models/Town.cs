namespace FootballDatabase.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Town
    {
        public Town()
        {
            this.Teams = new HashSet<Team>();
        }

        private const int MinNameLength = 2;
        private const int MaxNameLength = 50;

        public int Id { get; set; }

        //[Required]
        //[MinLength(MinNameLength)]
        //[MaxLength(MaxNameLength)]
        public int Name { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
