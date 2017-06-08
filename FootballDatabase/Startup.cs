namespace FootballDatabase
{
    using FootballDatabase.Utils;
    using FootballDatabase.Data;
    using FootballDatabase.Models;
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Writer writer = new Writer();
            Country[] countries = JSONReader.ReadCountries("../../../FootballDatabase/Data/countries.json");

            writer.WriteLine(countries[0].Name);
        }
    }
}
