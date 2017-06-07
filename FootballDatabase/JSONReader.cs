namespace FootballDatabase
{
    using System.IO;
    using System.Web.Script.Serialization;
    using FootballDatabase.Models;

    public static class JSONReader
    {
        private static JavaScriptSerializer serializer = new JavaScriptSerializer();

        public static Country[] ReadCountries(string filePath)
        {
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
