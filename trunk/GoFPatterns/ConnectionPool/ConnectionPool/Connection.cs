using System;

namespace ConnectionPool
{
    internal class Connection
    {
        private readonly int connectionNumber;
        private static int numberOfConnections;

        public Connection()
        {
            connectionNumber = numberOfConnections++;
        }

        public void Open()
        {
            Console.WriteLine("Opening connection {0}", connectionNumber);
        }

        public void Close()
        {
            Console.WriteLine("Closing connection {0}", connectionNumber);
        }
    }
}