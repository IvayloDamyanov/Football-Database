﻿namespace FootballDatabase
{
    using System.IO;
    using System.Web.Script.Serialization;
    using FootballDatabase.Models;

    public static class JSONParser
    {
        private static JavaScriptSerializer serializer = new JavaScriptSerializer();

        public static Player[] ReadPlayers(string filePath)
        {
            string fileContent = ReadJSON(filePath);
            return serializer.Deserialize<Player[]>(fileContent);
        }

        public static Country[] ReadCountries(string filePath)
        {
            string fileContent = ReadJSON(filePath);
            return serializer.Deserialize<Country[]>(fileContent);
        }

        public static Town[] ReadTowns(string filePath)
        {
            string fileContent = ReadJSON(filePath);
            return serializer.Deserialize<Town[]>(fileContent);
        }

        public static Team[] ReadTeams(string filePath)
        {
            string fileContent = ReadJSON(filePath);
            return serializer.Deserialize<Team[]>(fileContent);
        }

        public static Trainer[] ReadTrainers(string filePath)
        {
            string fileContent = ReadJSON(filePath);
            return serializer.Deserialize<Trainer[]>(fileContent);
        }

        public static Owner[] ReadOwners(string filePath)
        {
            string fileContent = ReadJSON(filePath);
            return serializer.Deserialize<Owner[]>(fileContent);
        }

        private static string ReadJSON(string filePath)
        {
            string fileContent;

            using (StreamReader streamReader = new StreamReader(filePath))
            {
                fileContent = streamReader.ReadToEnd();
            }

            return fileContent;
        }
    }
}