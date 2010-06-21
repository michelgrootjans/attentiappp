using System;
using System.Threading;

namespace LoadBalancer
{
    internal class Server
    {
        private static int numberOfServers;
        private readonly int serverId;

        public Server()
        {
            serverId = numberOfServers++;
            Thread.Sleep(500); //instantiating a server is expensive
        }

        public void GetWebPage(string pageName)
        {
            Console.WriteLine("Server {0} renders page {1}.", serverId, pageName);
            RenderWebPage(pageName);
        }

        private void RenderWebPage(string pageName)
        {
            // render some HTML here
            Thread.Sleep(100); //rendering a page takes a while
        }
    }
}