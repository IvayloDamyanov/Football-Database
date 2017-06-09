using FootballDatabase.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDatabase.Commands
{
    public class CommandParser
    {
        private Writer writer = new Writer();
        private Reader reader = new Reader();

        public CommandParser()
        {

        }

        public void MainChoice()
        {
            writer.WriteLine("Choose a number corresponding to a command:\n1 - Create new entry\n2 - Read and entry\n3 - Update an entry\n4 - Delete an entry");
            int numChoice = int.Parse(reader.ReadLine());
            switch (numChoice)
            {
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;
                default: writer.WriteLine("invalid choice"); break;
            }
        }
    }
}
