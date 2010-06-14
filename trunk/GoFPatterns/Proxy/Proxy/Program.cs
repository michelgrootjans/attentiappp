using System;

namespace Proxy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var server = new Server();

            for (var i = 0; i < 5; i++)
            {
                server.PerformComplexCalculation();
                Console.Write("Calculation result = ");
                Console.WriteLine(server.GetResult());
            }

            Console.ReadLine();
        }
    }
}