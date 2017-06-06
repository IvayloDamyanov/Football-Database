using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            var countries = JSONReader.ReadCountries("../../Data/countries.json");
            //Console.WriteLine(countries[0].CountryName);
        }
    }
}
