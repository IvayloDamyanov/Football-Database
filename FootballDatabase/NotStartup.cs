namespace FootballDatabase
{
    using FootballDatabase.Contracts;
    using FootballDatabase.Core;

    public class NotStartup
    {
        // Use only to populate the database
        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Start();
        }
    }
}
