using FootballDatabase.Utils.Contracts;
using System;

namespace FootballDatabase.Utils
{
    public class Reader : IReader
    {
        public Reader() { }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
