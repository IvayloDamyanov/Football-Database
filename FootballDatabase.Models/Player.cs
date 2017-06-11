namespace FootballDatabase.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Player
    {
        private const int MinNameLength = 2;
        private const int MaxNameLength = 50;
        private const int MinAge = 12;
        private const int MaxAge = 120;
        private const double MinSalary = 0.0;
        private const int MinYears = 0;

        public Player()
        {
            this.IsDeleted = false;
        }
    
        public int Id { get; set; }

        [Required]
        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        [Range(MinAge, MaxAge)]
        public int Age { get; set; }

        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        public string Nationality { get; set; }

        [Range(MinSalary, Double.MaxValue)]
        public decimal? Salary { get; set; }

        [Range(MinYears, Double.MaxValue)]
        public int? Contract { get; set; }

        public int TeamId { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Team Team { get; set; }

        public virtual Position Position { get; set; }

        public override string ToString()
        {
            return string.Format($@"Id: {this.Id}, Name: {this.Name}, Age: {this.Age}, Nationality: {this.Nationality}, Salary: {this.Salary}, Contract(in years): {this.Contract}, Position: {this.Position}");
        }
    }
}
