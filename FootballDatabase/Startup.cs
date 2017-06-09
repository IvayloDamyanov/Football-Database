namespace FootballDatabase
{
    using FootballDatabase.Contracts;
    using FootballDatabase.Core;

    public class Startup
    {
        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Start();
        }
    }
}
