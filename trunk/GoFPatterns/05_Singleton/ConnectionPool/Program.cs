using System;

namespace LoadBalancer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var server = new Server();
            for (var i = 0; i < 10; i++)
            {
                server.GetWebPage("index.htm");
            }
            Console.ReadLine();
        }
    }
}