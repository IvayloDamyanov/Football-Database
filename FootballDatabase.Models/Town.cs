namespace FootballDatabase.Models
{
    using System.Collections.Generic;

    public class Town
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
