namespace FootballDatabase
{
    using FootballDatabase.Data;
    using FootballDatabase.Models;
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            var countries = JSONReader.ReadCountries("../../Data/countries.json");
            //Console.WriteLine(countries[0].CountryName);
        }
    }
}
