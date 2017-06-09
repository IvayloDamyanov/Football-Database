namespace FootballDatabase.Utils
{
    using FootballDatabase.Utils.Contracts;
    using System;

    public class Reader : IReader
    {
        public Reader()
        {
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
