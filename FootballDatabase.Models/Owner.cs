namespace FootballDatabase.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Owner
    {
        private const int MinNameLength = 2;
        private const int MaxNameLength = 50;
        private const int MinAge = 30;
        private const int MaxAge = 80;
        private const double MinIncomes = 100000;

        public Owner()
        {
            this.IsDeleted = false;
            this.Teams = new HashSet<Team>();
        }

        public int Id { get; set; }

        public int TeamId { get; set; }

        [Required]
        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        public string Nationality { get; set; }

        [Range(MinAge, MaxAge)]
        public int Age { get; set; }

        [Range(MinIncomes, Double.MaxValue)]
        public decimal Incomes { get; set; }

        public bool IsDeleted { get; set; }

        [ForeignKey("TeamId")]
        public virtual ICollection<Team> Teams { get; set; }

        public override string ToString()
        {
            return string.Format($@"Id: {this.Id}, Name: {this.Name}, Age: {this.Age}, Nationality: {this.Nationality}, Incomes: {this.Incomes}");
        }
    }
}
