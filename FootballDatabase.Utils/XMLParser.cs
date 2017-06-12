namespace FootballDatabase.Utils
{
    using FootballDatabase.Models;
    using System.Xml;

    public static class XMLParser
    {
        public static Trainer[] ReadTrainers(string path)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(path);
            string xPathQuery = "/Trainers/Trainer";

            XmlNodeList trainerList = xmldoc.SelectNodes(xPathQuery);
            int nodeCount = trainerList.Count;
            Trainer[] trainers = new Trainer[nodeCount];

            for (int i = 0; i < nodeCount; i++)
            {
                XmlNode trainerNode = trainerList[i];

                trainers[i] = new Trainer()
                {
                    Id = int.Parse(trainerNode.ChildNodes[0].InnerText),
                    Name = trainerNode.ChildNodes[1].InnerText,
                    TeamId = int.Parse(trainerNode.ChildNodes[2].InnerText),
                    Nationality = trainerNode.ChildNodes[3].InnerText,
                    Age = int.Parse(trainerNode.ChildNodes[4].InnerText),
                    Salary = decimal.Parse(trainerNode.ChildNodes[5].InnerText),
                    Contract = int.Parse(trainerNode.ChildNodes[6].InnerText)
                };
            }

            return trainers;
        }
    }
}