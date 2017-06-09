namespace FootballDatabase.Core
{
    using System;
    using FootballDatabase.Commands;
    using FootballDatabase.Contracts;
    using FootballDatabase.Data;
    using Models;
    using System.Linq;

    public class Engine : IEngine
    {
        private static FootballDbContext context;
        private static DataWriter dataWriter;
        //private static QueryBuilder queryBuilder;

        public Engine()
        {
            context = new FootballDbContext();
            dataWriter = new DataWriter(context);
            //queryBuilder = new QueryBuilder(context);
        }

        public void Start()
        {
            dataWriter.Populate();
        }
    }
}
