namespace FootballDatabase.Core
{
    using FootballDatabase.Commands;
    using FootballDatabase.Contracts;
    using FootballDatabase.Data;

    public class Engine : IEngine
    {
        private FootballDbContext context = new FootballDbContext();
        private readonly DataWriter dataWriter;

        public Engine()
        {
            this.dataWriter = new DataWriter(this.context);
        }

        public void Start()
        {
            this.dataWriter.Populate();
        }
    }
}
