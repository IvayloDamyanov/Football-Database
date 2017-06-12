namespace FootballDatabase.Client.Core
{
    using System;
    using FootballDatabase.Client.Commands;
    using FootballDatabase.Client.Contracts;
    using FootballDatabase.Data;
    using Models;
    using System.Linq;

    public class Engine : IEngine
    {
        private FootballDbContext context;
        private DataWriter dataWriter;

        public Engine()
        {
            context = new FootballDbContext();
            dataWriter = new DataWriter(context);
        }

        public void Start()
        {
            dataWriter.Populate();
        }
    }
}
