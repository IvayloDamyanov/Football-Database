using System;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Web.Script.Serialization;
using FootballDatabase.Models;

namespace FootballDatabase
{
    static class JSONReader
    {
        private static JavaScriptSerializer serializer = new JavaScriptSerializer();

        public static Country[] ReadCountries(string filePath) {
            Country[] countries;

            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string fileContent = streamReader.ReadToEnd();
                countries = serializer.Deserialize<Country[]>(fileContent);
            }

            return countries;
        }
    }
}
