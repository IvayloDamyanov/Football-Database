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
            this.IsDeleted = false;
        }

        public int Id { get; set; }

        [Required]
        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<Town> Towns { get; set; }

        public override string ToString()
        {
            return string.Format($@"Id: {this.Id}, Name: {this.Name}");
        }
    }
}
