using System;

namespace LoadBalancer
{
    internal class Program
    {
        private static void Main()
        {
            for (var i = 0; i < 10; i++)
            {
                var server = new Server();
                server.GetWebPage("index.htm");
            }
            Console.ReadLine();
        }
    }
}