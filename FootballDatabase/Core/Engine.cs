namespace FootballDatabase.Client.Core
{
    using System;
    using FootballDatabase.Client.Commands;
    using FootballDatabase.Client.Contracts;
    using FootballDatabase.Data.Contexts;

    public class Engine : IEngine
    {
        private SqlServerFootballDbContext context;
        private DataWriter dataWriter;

        public Engine()
        {
            this.context = new SqlServerFootballDbContext();
            this.dataWriter = new DataWriter(this.context);
        }

        public void Start()
        {
            this.dataWriter.Populate();
        }
    }
}
