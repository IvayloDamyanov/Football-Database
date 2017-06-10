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
