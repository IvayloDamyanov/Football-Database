﻿namespace FootballDatabase.Utils
{
    using FootballDatabase.Utils.Contracts;
    using System;

    public class Writer : IWriter
    {
        public Writer()
        {
        }

        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
