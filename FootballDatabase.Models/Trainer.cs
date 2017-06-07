﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FootballDatabase.Models
{
    class Trainer
    {
        private const int MinNameLength = 2;
        private const int MaxNameLength = 50;
        private const int MinAge = 12;
        private const int MaxAge = 120;
        private const double MinSalary = 0.0;
        private const int MinYears = 0;

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
        public decimal Salary { get; set; }

        [Range(MinYears, Double.MaxValue)]
        public int Contract { get; set; }

        [MinLength(MinNameLength)]
        [MaxLength(MaxNameLength)]
        public virtual Team Team { get; set; }
    }
}