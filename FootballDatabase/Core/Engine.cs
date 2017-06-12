namespace FootballDatabase.Client.Core
{
    using System;
    using FootballDatabase.Client.Commands;
    using FootballDatabase.Client.Contracts;
    using FootballDatabase.Data;

    public class Engine : IEngine
    {
        private FootballDbContext context;
        private DataWriter dataWriter;

        public Engine()
        {
            this.context = new FootballDbContext();
            this.dataWriter = new DataWriter(this.context);
        }

        public void Start()
        {
            this.dataWriter.Populate();
        }
    }
}
