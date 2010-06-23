using System;
using Spring.Context;
using Spring.Context.Support;

namespace MovieFinder.Utilities
{
    public static class IocContainer
    {
        private static readonly IApplicationContext context;

        static IocContainer()
        {
            context = ContextRegistry.GetContext();
        }

        public static T GetAnImplementationOf<T>()
        {
            var dictionaryOfImplementations = context.GetObjectsOfType(typeof (T));
            if (dictionaryOfImplementations.Count == 1)
            {
                // This is the only way I found to get the first value in an 'old-style' IDictionary
                // returned by spring.net
                // -- Michel
                foreach (var implementation in dictionaryOfImplementations.Values)
                {
                    return implementation.As<T>();
                }
            }
            throw new ArgumentException(string.Format("Found {0} implementations of '{1}' in the IOC Container",
                                                      dictionaryOfImplementations.Count, typeof (T).Name));
        }
    }
}