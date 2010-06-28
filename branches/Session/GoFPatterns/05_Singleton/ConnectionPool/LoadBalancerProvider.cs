using System;
using System.Collections.Generic;

namespace LoadBalancer
{
    internal class LoadBalancerProvider
    {

        internal static SimpleLoadBalancer Instance
        {
            get { return SimpleLoadBalancer.Instance; }
        }

        internal class SimpleLoadBalancer
        {
            private readonly List<Server> servers;
            private readonly Random random = new Random();
            private static readonly SimpleLoadBalancer instance = new SimpleLoadBalancer();

            private SimpleLoadBalancer()
            {
                servers = new List<Server>
                          {
                              new Server(),
                              new Server()
                          };
            }

            public static SimpleLoadBalancer Instance
            {
                get { return instance; }
            }

            internal Server GetAvailableServer()
            {
                return servers[random.Next(servers.Count)];
            }
        }
    }
}