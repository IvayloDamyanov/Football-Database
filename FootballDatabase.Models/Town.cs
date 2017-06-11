namespace FootballDatabase.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Town
    {
        private const int MinNameLength = 2;
        private const int MaxNameLength = 50;

        public Town()
        {
            this.Teams = new HashSet<Team>();
            this.IsDeleted = false;
        }

        public int Id { get; set; }

        [Required]
        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        public int CountryId { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Team> Teams { get; set; }

        public override string ToString()
        {
            return string.Format($@"Id: {this.Id}, Name: {this.Name}");
        }
    }
}
