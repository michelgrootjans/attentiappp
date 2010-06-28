using System.Threading;

namespace Proxy
{
    internal class Server : IServer
    {
        private int result;

        public void PerformComplexCalculation()
        {
            //this simulates an expensive call over the network
            Thread.Sleep(1000);
            result = 42;
        }

        public int GetResult()
        {
            //this simulates an expensive call over the network
            Thread.Sleep(1000);
            return result;
        }
    }
}