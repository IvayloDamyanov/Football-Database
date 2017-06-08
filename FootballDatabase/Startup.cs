using FootballDatabase.Core;

namespace FootballDatabase
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Start();
        }
    }
}
