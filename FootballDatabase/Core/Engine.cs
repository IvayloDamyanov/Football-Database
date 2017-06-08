using FootballDatabase.Commands;
using FootballDatabase.Data;

namespace FootballDatabase.Core
{
    public class Engine
    {
        private FootballDbContext context = new FootballDbContext();

        public Engine()
        {

        }

        public void Start()
        {
            DataWriter dataWriter = new DataWriter(this.context);
            dataWriter.Populate();
        }
    }
}
