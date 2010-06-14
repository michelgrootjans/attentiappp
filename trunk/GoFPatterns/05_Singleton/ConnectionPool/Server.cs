using System;

namespace LoadBalancer
{
    internal class Server
    {
        private readonly int serverId;
        private static int numberOfServers;

        public Server()
        {
            serverId = numberOfServers++;
        }

        public void GetWebPage(string pageName)
        {
            Console.WriteLine("Server {0} renders page {1}.", serverId, pageName);
            RenderWebPage(pageName);
        }

        private void RenderWebPage(string pageName)
        {
            // render some HTML here
        }
    }
}