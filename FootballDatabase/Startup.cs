namespace FootballDatabase.Client
{
    using FootballDatabase.Client.Contracts;
    using FootballDatabase.Client.Core;
    using FootballDatabase.Utils.Models;

    public class Startup
    {
        // Use only to populate the database
        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Start();
        }
    }
}
