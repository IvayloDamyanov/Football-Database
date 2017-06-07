namespace FootballDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Startup
    {
        public static void Main(string[] args)
        {
            var countries = JSONReader.ReadCountries("../../Data/countries.json");
            //Console.WriteLine(countries[0].CountryName);
        }
    }
}
